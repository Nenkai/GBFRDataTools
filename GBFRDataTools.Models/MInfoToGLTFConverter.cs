using System.Numerics;
using System.Buffers.Binary;

using SharpGLTF;
using SharpGLTF.Schema2;
using SharpGLTF.Memory;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Materials;

using FlatSharp;
using Syroot.BinaryData;

using GraniteTextureReader.TileSet;

using GBFRDataTools.FlatBuffers;
using GraniteTextureReader;

namespace GBFRDataTools.Models;

public class MInfoToGLTFConverter
{
    private ModelRoot _gltfModel;
    private SharpGLTF.Schema2.Buffer _gltfBuffer;
    private Scene _gltfScene;

    /// <summary>
    /// Current model name.
    /// </summary>
    private string _modelName;

    /// <summary>
    /// Relink game directory.
    /// </summary>
    private string _gameDir;

    /// <summary>
    /// Model directory for the current model.
    /// </summary>
    private string _modelDir;

    /// <summary>
    /// .minfo file of the current model.
    /// </summary>
    private ModelInfo _modelInfo;

    /// <summary>
    /// .mmat file for the current model.
    /// </summary>
    private ModelMaterialSet _modelMatSet;

    private ModelSkeleton _skeleton;
    private Node _armature;
    private List<Node> _allJoints;
    private Skin _skin;

    /// <summary>
    /// Stream for the glTF buffer.
    /// </summary>
    private BinaryStream _bufBinaryStream;

    private string _outputDir;

    private Dictionary<int, GraniteProcessor> _graniteTileSets = [];

    public MInfoToGLTFConverter(string gameDir)
    {
        _gameDir = gameDir;
    }

    public void Load(string modelName, int matNumber = 0)
    {
        _modelName = modelName;
        _modelDir = Path.Combine(_gameDir, "model", modelName.Substring(0, 2), _modelName);

        // Parse mminfo 
        string minfoPath = Path.Combine(_modelDir, $"{modelName}.minfo");
        byte[] minfoBuf = File.ReadAllBytes(minfoPath);
        _modelInfo = ModelInfo.Serializer.Parse(minfoBuf);

        // Parse mmat (minfo will link to it)
        string mmatPath = Path.Combine(_modelDir, "vars", $"{matNumber}.mmat");
        byte[] mmatBuf = File.ReadAllBytes(mmatPath);
        _modelMatSet = ModelMaterialSet.Serializer.Parse(mmatBuf);

        // Parse skeleton
        string skelPath = Path.Combine(_modelDir, $"{_modelName}.skeleton");
        if (File.Exists(skelPath))
        {
            byte[] skelBuf = File.ReadAllBytes(skelPath);
            _skeleton = ModelSkeleton.Serializer.Parse(skelBuf);
        }
    }

    public void Convert(string outputDir)
    {
        string dir = Path.GetFullPath(outputDir);
        Directory.CreateDirectory(dir);
        _outputDir = dir;

        /* Start creating the glTF model and its linked buffer. There can only be one singular buffer.
        * The initial strategy was to just copy and paste the mmesh buffers into glTF, but turns out glTF
        * does not support half floats, so the buffer has to be reshaped anyway
        * 
        * It'll be done inside each lod sub-mesh
        */

        _gltfModel = ModelRoot.CreateModel();
        byte[] gltfBuffer = new byte[CalculateGLTFBufferSize(_modelInfo)];
        _gltfBuffer = _gltfModel.UseBuffer(gltfBuffer);
        _gltfScene = _gltfModel.UseScene(0);

        ProcessSkeleton();

        using var bufStream = new MemoryStream(gltfBuffer);
        _bufBinaryStream = new BinaryStream(bufStream);

        for (int i = 0; i < 1; i++)
        {
            HandleLOD(i);
        }

        for (int i = 0; i < _modelInfo.ShadowLods.Count; i++)
        {
            HandleShadowLOD(i);
        }

        _gltfModel.SaveGLTF(Path.Combine(outputDir, $"{_modelName}.gltf"), new WriteSettings()
        {
            ImageWriteCallback = null, // Don't let it rewrite external files unnecessarily
            ImageWriting = ResourceWriteMode.SatelliteFile,
            JsonIndented = true,
            Validation = SharpGLTF.Validation.ValidationMode.TryFix, // Needed cause sometimes normals are 0,0,0 and it doesn't like that?
        });
    }

    private void HandleLOD(int lodNumber)
    {
        StreamLOD lod = _modelInfo.Lods[lodNumber];
        HandleLODEntity(lod, $"lod{lodNumber}");
    }

    private void HandleShadowLOD(int lodNumber)
    {
        StreamLOD lod = _modelInfo.ShadowLods[lodNumber];
        HandleLODEntity(lod, $"shadowlod{lodNumber}");
    }

    private void HandleLODEntity(StreamLOD lod, string meshName)
    {
        string lodMeshPath = Path.Combine(_gameDir, "model_streaming", meshName, $"{_modelName}.mmesh");

        using FileStream lodMeshStream = File.Open(lodMeshPath, FileMode.Open);
        using BinaryStream lodMeshBinaryStream = new BinaryStream(lodMeshStream);

        // Go through each sub mesh (each sub mesh 'chunk' uses a different material)
        int vertOffset = 0;

        for (int i = 0; i < lod.Chunks.Count; i++)
        {
            Node node = _gltfScene.CreateNode();
            
            LODChunk chunk = lod.Chunks[i];
            SubMeshInfo subMeshInfo = _modelInfo.SubMeshes[chunk.SubMeshId];

            Mesh gltfMesh = _gltfModel.CreateMesh($"{meshName}.{subMeshInfo.Name}.{i}");
            MeshPrimitive primitive = gltfMesh.CreatePrimitive();

            lodMeshBinaryStream.Position = (int)lod.MeshBuffers[^1].Offset;
            int numVerts = GetNumUsedVerts(lodMeshBinaryStream, chunk.PolyOffset, chunk.PolyCount, vertOffset);

            int idx = 0;
            for (int type = 0; type <= 6; type++)
            {
                VertexBufferType checkType = (VertexBufferType)(1 << type);
                if (!lod.BufferTypes.HasFlag(checkType))
                    continue;

                MeshBufferLocator bufLocator = lod.MeshBuffers[idx];
                lodMeshBinaryStream.Position = (int)bufLocator.Offset;

                switch (checkType)
                {
                    case VertexBufferType.POS_NOR_TAN_UV0:
                        CreateLODPosNorTanUvAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, vertOffset, numVerts);
                        break;
                    case VertexBufferType.BLENDINDICES:
                        CreateLODBlendIndicesAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, vertOffset, numVerts, 0);
                        break;
                    case VertexBufferType.BLENDINDICES_2:
                        CreateLODBlendIndicesAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, vertOffset, numVerts, 1);
                        break;
                    case VertexBufferType.BLENDWEIGHT:
                        CreateLODBlendWeightsAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, vertOffset, numVerts, 0);
                        break;
                    case VertexBufferType.BLENDWEIGHT_2:
                        CreateLODBlendWeightsAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, vertOffset, numVerts, 1); 
                        break;
                    case VertexBufferType.COLOR:
                        // TODO
                        //CreateLODColorsAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, vertOffset, numVerts);
                        break;
                    default:
                        throw new NotSupportedException();
                }

                idx++;
            }

            MeshBufferLocator indicesLocator = lod.MeshBuffers[^1];
            lodMeshBinaryStream.Position = (int)indicesLocator.Offset;
            CreateIndexAccessor(lodMeshBinaryStream, _bufBinaryStream, primitive, chunk.PolyOffset, chunk.PolyCount, vertOffset);

            vertOffset += numVerts;

            // Process mat
            MaterialInfo matInfo = _modelInfo.Materials[chunk.MaterialId];
            FlatBuffers.Material mat = _modelMatSet.Materials[chunk.MaterialId];

            SharpGLTF.Schema2.Material gltfMaterial = _gltfModel.CreateMaterial();
            gltfMaterial.WithDefault();

            int layer = 0;
            int pageFileId = 0;
            foreach (var map in mat.TextureMaps)
            {
                string channelName = "";
                switch (map.ShaderMapNameHash)
                {
                    case ShaderMapTypeHash.g_AlbedoMap:
                        channelName = "BaseColor";
                        layer = 0;
                        break;
                    case ShaderMapTypeHash.g_EyeWhiteTexture:
                        channelName = "BaseColor";
                        layer = 0;
                        break;
                    case ShaderMapTypeHash.g_NormalMap:
                        channelName = "Normal";
                        layer = 1;
                        break;
                    case ShaderMapTypeHash.g_AlbedoTex0:
                        channelName = "BaseColor";
                        layer = (mat.GraniteParams.LayerToShaderMapNameHash.Count % mat.GraniteParams.PageFile.Count);
                        pageFileId = 0;
                        break;
                    case ShaderMapTypeHash.g_NormalTex0:
                        channelName = "Normal";
                        layer = (mat.GraniteParams.LayerToShaderMapNameHash.Count % mat.GraniteParams.PageFile.Count) + 1;
                        pageFileId = 0;
                        break;
                    case ShaderMapTypeHash.g_MaskTex0:
                        layer = (mat.GraniteParams.LayerToShaderMapNameHash.Count % mat.GraniteParams.PageFile.Count) + 2;
                        pageFileId = 0;
                        break;
                    case ShaderMapTypeHash.g_AlbedoTex1:
                        channelName = "BaseColor";
                        layer = (mat.GraniteParams.LayerToShaderMapNameHash.Count % mat.GraniteParams.PageFile.Count);
                        pageFileId = 1;
                        break;
                    case ShaderMapTypeHash.g_NormalTex1:
                        channelName = "Normal";
                        layer = (mat.GraniteParams.LayerToShaderMapNameHash.Count % mat.GraniteParams.PageFile.Count) + 1;
                        pageFileId = 1;
                        break;
                    case ShaderMapTypeHash.g_MaskTex1:
                        layer = (mat.GraniteParams.LayerToShaderMapNameHash.Count % mat.GraniteParams.PageFile.Count) + 2;
                        pageFileId = 1;
                        break;
                    default:
                        layer = mat.GraniteParams.LayerToShaderMapNameHash.IndexOf(map.ShaderMapNameHash);
                        break;
                }

                string filePath = Path.Combine(_outputDir, map.TextureName + ".png");
                if (!File.Exists(filePath))
                {
                    if (mat.GraniteParams is not null)
                    {
                        if (layer != -1)
                        {
                            GraniteProcessor graniteProcessor = GetGraniteTileSetProcessor(mat.GraniteParams.TileSetNumber);
                            graniteProcessor.Extract(layer, mat.GraniteParams.PageFile[pageFileId], _outputDir, map.TextureName + ".png");
                        }
                    }
                    else
                    {
                        ;
                    }
                }

                if (File.Exists(filePath))
                {
                    Image gltfImage = _gltfModel.CreateImage(map.TextureName);
                    gltfImage.Content = new MemoryImage(Path.Combine(_outputDir, map.TextureName + ".png"));
                    gltfImage.AlternateWriteFileName = map.TextureName + ".png";

                    if (!string.IsNullOrEmpty(channelName))
                        gltfMaterial.WithChannelTexture(channelName, 0, gltfImage);
                }
            }

            primitive.Material = gltfMaterial;

            node.WithMesh(gltfMesh);
            if (_skeleton is not null)
                node.WithSkin(_skin);
        }        
    }

    public void ProcessSkeleton()
    {
        // Note to self: bone also means joint
        if (_skeleton is not null)
        {
            _armature = _gltfScene.CreateNode();
            _allJoints = [];

            JointNode root = new JointNode() { ThisGLTFNode = _armature };
            Dictionary<int, JointNode> boneIndexToJointNode = [];

            for (int boneIdx = 0; boneIdx < _skeleton.Body.Count; boneIdx++)
            {
                Bone bone = _skeleton.Body[boneIdx];
                JointNode parentNode = bone.ParentID == -1 ? root : 
                    boneIndexToJointNode.ContainsKey(bone.ParentID) ? boneIndexToJointNode[bone.ParentID] :
                    throw new Exception($"Bone {bone.ParentID} missing?");

                Node gltfJointNode = parentNode.ThisGLTFNode.CreateNode(bone.Name)
                        .WithLocalTranslation(new Vector3(bone.Translation.X, bone.Translation.Y, bone.Translation.Z))
                        .WithLocalRotation(new System.Numerics.Quaternion(bone.Rotation.X, bone.Rotation.Y, bone.Rotation.Z, bone.Rotation.W))
                        .WithLocalScale(new Vector3(bone.Scale.X, bone.Scale.Y, bone.Scale.Z));

                JointNode jointBranch = new()
                {
                    ThisGLTFNode = gltfJointNode
                };

                if (bone.ParentID == -1)
                {
                    _allJoints.Add(gltfJointNode);
                    root.Joints.Add(jointBranch);
                    boneIndexToJointNode.Add(boneIdx, jointBranch);
                }
                else
                {
                    if (!boneIndexToJointNode.TryGetValue(bone.ParentID, out JointNode joint))
                        throw new Exception($"Bone {bone.ParentID} missing?");

                    _allJoints.Add(gltfJointNode);
                    joint.Joints.Add(jointBranch);
                    boneIndexToJointNode.Add(bone.A1.BoneID, jointBranch);
                }
            }

            _skin = _gltfModel.CreateSkin("Armature");
            _skin.BindJoints(_allJoints.ToArray());
        }
    }

    public class JointNode
    {
        public Node ThisGLTFNode;
        public List<JointNode> Joints = [];
    }

    private void CreateLODPosNorTanUvAccessor(BinaryStream lodMeshBinaryStream, BinaryStream outputVertexStream, MeshPrimitive gltfPrimitive, int vertexOffset, int numVertices)
    {
        lodMeshBinaryStream.Position += vertexOffset * 0x20;
        int offset = (int)outputVertexStream.Position;

        for (int j = 0; j < numVertices; j++)
        {
            // Position
            outputVertexStream.WriteSingle(lodMeshBinaryStream.ReadSingle());
            outputVertexStream.WriteSingle(lodMeshBinaryStream.ReadSingle());
            outputVertexStream.WriteSingle(lodMeshBinaryStream.ReadSingle());

            // Normal
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            lodMeshBinaryStream.Position += 0x02; // Pad

            // Tangent
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16())); // bitangent sign

            // Texcoord
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle(1.0f - (float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
        }
        int size = (int)outputVertexStream.Position - offset;

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, size, byteStride: 0x30);

        Accessor positionAccessor = _gltfModel.CreateAccessor();
        positionAccessor.SetVertexData(vertexBufView, 0x00, numVertices);
        gltfPrimitive.SetVertexAccessor("POSITION", positionAccessor);

        Accessor normalAccessor = _gltfModel.CreateAccessor();
        normalAccessor.SetVertexData(vertexBufView, 0x0C, numVertices);
        gltfPrimitive.SetVertexAccessor("NORMAL", normalAccessor);

        Accessor tangentAccessor = _gltfModel.CreateAccessor();
        tangentAccessor.SetVertexData(vertexBufView, 0x18, numVertices, dimensions: DimensionType.VEC4);
        gltfPrimitive.SetVertexAccessor("TANGENT", tangentAccessor);

        Accessor texcoordAccessor = _gltfModel.CreateAccessor();
        texcoordAccessor.SetData(vertexBufView, 0x28, numVertices, DimensionType.VEC2, EncodingType.FLOAT, false);
        gltfPrimitive.SetVertexAccessor("TEXCOORD_0", texcoordAccessor);
    }

    private void CreateLODBlendIndicesAccessor(BinaryStream lodMeshBinaryStream, BinaryStream outputVertexStream, MeshPrimitive gltfPrimitive, int vertexOffset, int numVertices, int idx)
    {
        lodMeshBinaryStream.Position += vertexOffset * 0x08;
        int offset = (int)outputVertexStream.Position;

        for (int j = 0; j < numVertices; j++)
        {
            short deformBone1 = lodMeshBinaryStream.ReadInt16();
            short deformBone2 = lodMeshBinaryStream.ReadInt16();
            short deformBone3 = lodMeshBinaryStream.ReadInt16();
            short deformBone4 = lodMeshBinaryStream.ReadInt16();

            outputVertexStream.WriteUInt16(_modelInfo.DeformBoneToBoneIndexTable[deformBone1]);
            outputVertexStream.WriteUInt16(_modelInfo.DeformBoneToBoneIndexTable[deformBone2]);
            outputVertexStream.WriteUInt16(_modelInfo.DeformBoneToBoneIndexTable[deformBone3]);
            outputVertexStream.WriteUInt16(_modelInfo.DeformBoneToBoneIndexTable[deformBone4]);
        }
        int size = (int)outputVertexStream.Position - offset;

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, size, byteStride: 0x08);

        Accessor jointsAccessor = _gltfModel.CreateAccessor();
        jointsAccessor.SetVertexData(vertexBufView, 0x00, numVertices, dimensions: DimensionType.VEC4, EncodingType.UNSIGNED_SHORT);
        gltfPrimitive.SetVertexAccessor($"JOINTS_{idx}", jointsAccessor);
    }


    private void CreateLODBlendWeightsAccessor(BinaryStream lodMeshBinaryStream, BinaryStream outputVertexStream, MeshPrimitive gltfPrimitive, int vertexOffset, int numVertices, int idx)
    {
        lodMeshBinaryStream.Position += vertexOffset * 0x08;
        int offset = (int)outputVertexStream.Position;

        for (int j = 0; j < numVertices; j++)
        {
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
        }
        int size = (int)outputVertexStream.Position - offset;

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, size, byteStride: 0x08);

        Accessor jointsAccessor = _gltfModel.CreateAccessor();
        jointsAccessor.SetVertexData(vertexBufView, 0x00, numVertices, dimensions: DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, normalized: true);
        gltfPrimitive.SetVertexAccessor($"WEIGHTS_{idx}", jointsAccessor);
    }

    private void CreateLODColorsAccessor(BinaryStream lodMeshBinaryStream, BinaryStream outputVertexStream, MeshPrimitive gltfPrimitive, int vertexOffset, int numVertices)
    {
        lodMeshBinaryStream.Position += vertexOffset * 0x04;
        int offset = (int)outputVertexStream.Position;

        for (int j = 0; j < numVertices; j++)
        {
            outputVertexStream.WriteByte(lodMeshBinaryStream.Read1Byte());
            outputVertexStream.WriteByte(lodMeshBinaryStream.Read1Byte());
            outputVertexStream.WriteByte(lodMeshBinaryStream.Read1Byte());
            outputVertexStream.WriteByte(lodMeshBinaryStream.Read1Byte());
        }
        int size = (int)outputVertexStream.Position - offset;

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, size, byteStride: 0x04);

        Accessor jointsAccessor = _gltfModel.CreateAccessor();
        jointsAccessor.SetVertexData(vertexBufView, 0x00, numVertices, dimensions: DimensionType.VEC4, EncodingType.BYTE, normalized: true);
        gltfPrimitive.SetVertexAccessor($"COLOR_0", jointsAccessor);
    }

    /// <summary>
    /// Creates the glTF mesh indices accessor.
    /// </summary>
    /// <param name="lodMeshBinaryStream"></param>
    /// <param name="outputVertexStream"></param>
    /// <param name="gltfPrimitive"></param>
    /// <param name="polyOffset"></param>
    /// <param name="polyCount"></param>
    /// <param name="test"></param>
    private void CreateIndexAccessor(BinaryStream lodMeshBinaryStream, BinaryStream outputVertexStream, MeshPrimitive gltfPrimitive, int polyOffset, int polyCount, int test)
    {
        lodMeshBinaryStream.Position += polyOffset * sizeof(int);
        int offset = (int)outputVertexStream.Position;

        for (int i = 0; i < polyCount; i++)
        {
            uint index = lodMeshBinaryStream.ReadUInt32();
            outputVertexStream.WriteUInt32((uint)(index - test));
        }
        int size = (int)outputVertexStream.Position - offset;

        BufferView indicesBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, size, byteStride: 0);
        Accessor indicesAccessor = _gltfModel.CreateAccessor();
        indicesAccessor.SetIndexData(indicesBufView, 0, polyCount, IndexEncodingType.UNSIGNED_INT);
        
        gltfPrimitive.SetIndexAccessor(indicesAccessor);
    }

    /// <summary>
    /// Gets the number of vertex used using poly indices.
    /// </summary>
    /// <param name="lodMeshBinaryStream"></param>
    /// <param name="polyOffset"></param>
    /// <param name="polyCount"></param>
    /// <param name="vertOffset"></param>
    /// <returns></returns>
    public static int GetNumUsedVerts(BinaryStream lodMeshBinaryStream, int polyOffset, int polyCount, int vertOffset)
    {
        lodMeshBinaryStream.Position += polyOffset * sizeof(int);

        int max = 0;
        for (int i = 0; i < polyCount; i++)
        {
            int index = lodMeshBinaryStream.ReadInt32();
            if (index > max)
                max = index;
        }

        return (max + 1) - vertOffset;
    }

    /// <summary>
    /// Calculates the size of the mesh/vertex/index buffer for the glTF file.
    /// </summary>
    /// <param name="info"></param>
    /// <returns></returns>
    public static int CalculateGLTFBufferSize(ModelInfo info)
    {
        int totalSize = 0;

        for (int i = 0; i < info.Lods.Count; i++)
        {
            StreamLOD lod = info.Lods[i];
            int idx = 0;
            for (int type = 0; type <= 6; type++)
            {
                VertexBufferType checkType = (VertexBufferType)(1 << type);
                if (!lod.BufferTypes.HasFlag(checkType))
                    continue;

                switch (checkType)
                {
                    case VertexBufferType.POS_NOR_TAN_UV0:
                        totalSize += lod.VertexCount * (
                            (3 * sizeof(float)) +  // POSITION (Vec3)
                            (3 * sizeof(float)) +  // NORMAL (Vec3)
                            (4 * sizeof(float)) +  // TANGENT (Vec4)
                            (2 * sizeof(float)));  // UV (Vec2)
                        break;
                    case VertexBufferType.BLENDINDICES:
                    case VertexBufferType.BLENDINDICES_2:
                    case VertexBufferType.BLENDWEIGHT:
                    case VertexBufferType.BLENDWEIGHT_2:
                        totalSize += lod.VertexCount * (sizeof(short) * 4);
                        break;
                }

                idx++;
            }

            totalSize += lod.IndexCount * sizeof(int); // Indices
        }

        return totalSize;
    }

    public string GetGraniteDir(int tileSetNumber)
    {
        return Path.Combine(_gameDir, "granite", "4k", "gts", tileSetNumber.ToString());
    }

    public GraniteProcessor GetGraniteTileSetProcessor(int tileSetNumber)
    {
        if (_graniteTileSets.TryGetValue(tileSetNumber, out GraniteProcessor processor))
            return processor;

        string tileSetFile = Path.Combine(GetGraniteDir(tileSetNumber), $"{tileSetNumber}.gts");
        var tileSet = new TileSetFile();
        tileSet.Initialize(tileSetFile);

        processor = GraniteProcessor.CreateFromTileSet(tileSetFile);
        _graniteTileSets[tileSetNumber] = processor;
        return processor;
    }

}
