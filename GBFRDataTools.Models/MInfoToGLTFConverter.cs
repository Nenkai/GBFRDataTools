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
using System.Reflection.Emit;
using SixLabors.ImageSharp.Textures;

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

    /// <summary>
    /// Stream for the glTF buffer.
    /// </summary>
    private BinaryStream _bufBinaryStream;

    private string _outputDir;

    private Dictionary<int, TileSetFile> _graniteTileSets = [];

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

        _gltfModel.SaveGLTF(Path.Combine(outputDir, $"{_modelName}.gltf"));
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

            if (mat.GraniteParams is not null)
            {
                TileSetFile tileSet = GetGraniteTileSet(mat.GraniteParams.TileSetNumber);

                var graniteProcessor = new GraniteProcessor();
                graniteProcessor.Read(GetGraniteDir(mat.GraniteParams.TileSetNumber), tileSet);
                graniteProcessor.Extract(-1, mat.GraniteParams.PageFile.First(), _outputDir);
            }
            else
            {

            }

            SharpGLTF.Schema2.Material gltfMaterial = _gltfModel.CreateMaterial();
            
            node.WithMesh(gltfMesh);
           
        }
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
            outputVertexStream.WriteSingle((float)-BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)-BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)-BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            lodMeshBinaryStream.Position += 0x02; // Pad

            // Tangent
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16())); // bitangent sign

            // Texcoord
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
            outputVertexStream.WriteSingle((float)BitConverter.UInt16BitsToHalf(lodMeshBinaryStream.ReadUInt16()));
        }

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, byteStride: 0x30);

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
            // Position
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
            outputVertexStream.WriteUInt16(lodMeshBinaryStream.ReadUInt16());
        }

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, byteStride: 0x08);

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

        BufferView vertexBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, byteStride: 0x08);

        Accessor jointsAccessor = _gltfModel.CreateAccessor();
        jointsAccessor.SetVertexData(vertexBufView, 0x00, numVertices, dimensions: DimensionType.VEC4, EncodingType.UNSIGNED_SHORT, normalized: true);
        gltfPrimitive.SetVertexAccessor($"WEIGHTS_{idx}", jointsAccessor);
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

        BufferView indicesBufView = _gltfModel.UseBufferView(_gltfBuffer, offset, byteStride: 0);
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

    public TileSetFile GetGraniteTileSet(int tileSetNumber)
    {
        if (_graniteTileSets.TryGetValue(tileSetNumber, out TileSetFile tileSet))
            return tileSet;

        tileSet = new TileSetFile();
        tileSet.Initialize(Path.Combine(GetGraniteDir(tileSetNumber), $"{tileSetNumber}.gts"));
        _graniteTileSets[tileSetNumber] = tileSet;
        return tileSet;
    }

}
