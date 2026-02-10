using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;
using System.Numerics;
using System.Globalization;

using YamlDotNet.RepresentationModel;

using GBFRDataTools.Hashing;

using GBFRDataTools.Files.UI.Types;
using YamlDotNet.Core.Tokens;

namespace GBFRDataTools.Files.UI;

public class BulkWriter
{
    // TODO: Elements are actually hashed in full regardless of type. We shouldn't be keeping track of each type and their offsets
    private Dictionary<Vector2, long> _writtenVec2s = [];
    private Dictionary<Vector3, long> _writtenVec3s = [];
    private Dictionary<Vector4, long> _writtenVec4s = [];
    private Dictionary<int, long> _writtenIntegers = [];
    private Dictionary<float, long> _writtenFloats = [];
    private Dictionary<UIObjectRef, long> _writtenIds = [];

    private Dictionary<long, long> _hashTableToOffset = [];

    public void Write(string file, YamlNode root)
    {
        using var fs = File.Create(file);
        using var bs = new BinaryStream(fs);

        bs.Position = 0x04;

        var mapNode = root as YamlMappingNode;
        long rootTableOffset = WriteObjectNode(bs, mapNode, KnownProperties.List);
        bs.Position = 0;
        bs.WriteUInt32((uint)rootTableOffset);
    }

    private long WriteObjectNode(BinaryStream bs, YamlNode node, List<UIPropertyTypeDef> validProperties)
    {
        if (node is YamlMappingNode mapNode)
        {
            // Write property names hash list
            // Build the list of hashes, it'll be used as for whether to point back to a previous table
            List<uint> hashes = new(mapNode.Children.Count);

            // have to order nodes for bsearch
            var orderedNodes = mapNode.Children.OrderBy(e =>
            {
                var keyNode = e.Key as YamlScalarNode;
                return XXHash32Custom.Hash(keyNode.Value);
            });

            foreach (var childNode in orderedNodes)
            {
                YamlScalarNode keyNode = childNode.Key as YamlScalarNode;
                if (keyNode.Value.StartsWith('_'))
                {
                    uint hash = uint.Parse(keyNode.Value[1..], NumberStyles.HexNumber);
                    hashes.Add(hash);
                }
                else
                    hashes.Add(XXHash32Custom.Hash(keyNode.Value));
            }

            long sum = hashes.Sum(e => e);
            if (!_hashTableToOffset.TryGetValue(sum, out long propTableOffset))
            {
                propTableOffset = bs.Position;

                _hashTableToOffset.Add(sum, bs.Position);
                bs.WriteUInt32((uint)mapNode.Children.Count);

                for (int i = 0; i < hashes.Count; i++)
                    bs.WriteUInt32(hashes[i]);
            }

            // Write node values
            List<long> offsets = new(mapNode.Children.Count);
            foreach (var childNode in orderedNodes)
            {
                YamlScalarNode keyNode = childNode.Key as YamlScalarNode;

                uint hash;
                if (keyNode.Value.StartsWith('_'))
                    hash = uint.Parse(keyNode.Value[1..], NumberStyles.HexNumber);
                else
                    hash = XXHash32Custom.Hash(keyNode.Value);

                var validPropertiesDict = validProperties.ToDictionary(e => e.Hash);
                if (!validPropertiesDict.TryGetValue(hash, out UIPropertyTypeDef propertyTypedef))
                    throw new KeyNotFoundException("Property not found");

                List<UIPropertyTypeDef> childProperties = propertyTypedef.ChildProperties;

                if (propertyTypedef.Name.Equals("Component"))
                {
                    YamlNode compNameNode = mapNode.Children.FirstOrDefault(e => (e.Key as YamlScalarNode).Value == "ComponentName").Value;
                    string compName = ((YamlScalarNode)compNameNode).Value;

                    if (!KnownProperties.ComponentList.TryGetValue(compName, out childProperties))
                        throw new KeyNotFoundException($"Unmapped/Unsupported component '{compName}'");
                }

                var value = childNode.Value;
                if (value is YamlMappingNode mappingNode)
                {
                    if (propertyTypedef.Type == UIFieldType.ObjectRef)
                    {
                        long objectRefOffset = WriteObjectRefNode(bs, mappingNode);
                        offsets.Add(objectRefOffset);
                    }
                    else
                    {
                        long nodeOfs = WriteObjectNode(bs, mappingNode, childProperties);
                        offsets.Add(nodeOfs);
                    }
                }
                else if (value is YamlSequenceNode seqNode)
                {
                    long nodeOfs = WriteSequenceElement(bs, seqNode, childProperties, propertyTypedef);
                    offsets.Add(nodeOfs);
                }
                else if (value is YamlScalarNode scalarNode)
                {
                    long scalarOffset = WriteScalar(bs, scalarNode, propertyTypedef);
                    offsets.Add(scalarOffset);
                }
                else
                    throw new NotSupportedException("Unsupported yaml element type?");
            }

            long retOffset = bs.Position;
            bs.WriteInt32((int)(propTableOffset - bs.Position));

            long tableOffset = bs.Position;
            // Write offsets to child values
            for (int i = 0; i < offsets.Count; i++)
            {
                long actual = (int)(offsets[i] - retOffset);
                bs.WriteInt32((int)actual);
            }

            return retOffset;
        }

        return 0;
    }

    private long WriteSequenceElement(BinaryStream bs, YamlSequenceNode seqNode, List<UIPropertyTypeDef> validProperties, UIPropertyTypeDef elemTypeDef)
    {
        List<long> offsets = new List<long>(seqNode.Children.Count);
        foreach (var elem in seqNode)
        {
            if (elem is YamlScalarNode scal)
            {
                long scalarOffset = WriteScalar(bs, scal, elemTypeDef);
                offsets.Add(scalarOffset);
            }
            else if (elemTypeDef.Type == UIFieldType.ObjectRefVector)
            {
                long scalarOffset = WriteObjectRefNode(bs, elem as YamlMappingNode);
                offsets.Add(scalarOffset);
            }
            else
            {
                long elemOffset = WriteObjectNode(bs, elem, validProperties);
                offsets.Add(elemOffset);
            }
        }

        long baseOfs = bs.Position;
        bs.WriteUInt32((uint)seqNode.Children.Count);
        for (int i = 0; i < seqNode.Children.Count; i++)
        {
            long actual = (int)(offsets[i] - baseOfs);
            bs.WriteInt32((int)actual);
        }

        return baseOfs;
    }

    private long WriteObjectRefNode(BinaryStream bs, YamlMappingNode objRefNode)
    {
        long scalarOffset = bs.Position;

        UIObjectRef objRef = ParseObjectRefNode(objRefNode);
        if (_writtenIds.TryAdd(objRef, scalarOffset))
            objRef.Write(bs);
        else
            scalarOffset = _writtenIds[objRef];

        return scalarOffset;
    }

    private long WriteScalar(BinaryStream bs, YamlScalarNode scalarNode, UIPropertyTypeDef def)
    {
        long scalarOffset = bs.Position;

        switch (def.Type)
        {
            case UIFieldType.CVec2:
                {
                    UIVec2 vec2 = ParseVector2(scalarNode.Value);
                    if (_writtenVec2s.TryAdd(vec2.Vector, scalarOffset))
                        vec2.Write(bs);
                    else
                        scalarOffset = _writtenVec2s[vec2.Vector];
                    break;
                }

            case UIFieldType.CVec3:
                {
                    UIVec3 vec3 = ParseVector3(scalarNode.Value);
                    if (_writtenVec3s.TryAdd(vec3.Vector, scalarOffset))
                        vec3.Write(bs);
                    else
                        scalarOffset = _writtenVec3s[vec3.Vector];
                    break;
                }

            case UIFieldType.CVec4:
                {
                    UIVec4 vec4 = ParseVector4(scalarNode.Value);
                    if (_writtenVec4s.TryAdd(vec4.Vector, scalarOffset))
                        vec4.Write(bs);
                    else
                        scalarOffset = _writtenVec4s[vec4.Vector];
                    break;
                }

            case UIFieldType.String:
            case UIFieldType.StringVector:
                {
                    UIString str = ParseString(scalarNode.Value);
                    str.Write(bs);
                    break;
                }

            case UIFieldType.Bool:
                {
                    UIBool boolValue = ParseBool(scalarNode.Value);
                    if (_writtenIntegers.TryAdd(boolValue.Value ? 1 : 0, scalarOffset))
                        boolValue.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[boolValue.Value ? 1 : 0];
                    break;
                }
            case UIFieldType.S32:
            case UIFieldType.S32Vector:
                {
                    UI_S32 value = ParseS32(scalarNode.Value);
                    if (_writtenIntegers.TryAdd(value.Value, scalarOffset))
                        value.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[value.Value];
                    break;
                }

            case UIFieldType.U32:
                {
                    UI_U32 value = ParseU32(scalarNode.Value);
                    if (_writtenIntegers.TryAdd((int)value.Value, scalarOffset))
                        value.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[(int)value.Value];
                    break;
                }

            case UIFieldType.CyanStringHash:
                {
                    CyanStringHash hash = ParseStringHash(scalarNode.Value);
                    if (_writtenIntegers.TryAdd((int)hash.Hash, scalarOffset))
                        hash.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[(int)hash.Hash];
                    break;
                }

            case UIFieldType.F32:
                {
                    UIFloat @float = ParseFloat(scalarNode.Value);
                    if (_writtenFloats.TryAdd(@float.Value, scalarOffset))
                        @float.Write(bs);
                    else
                        scalarOffset = _writtenFloats[@float.Value];
                    break;
                }

            case UIFieldType.S8:
                {
                    UI_S8 value = ParseS8(scalarNode.Value);
                    if (_writtenIntegers.TryAdd(value.Value, scalarOffset))
                        value.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[value.Value];
                    break;
                }

            case UIFieldType.S16:
                {
                    UI_S16 value = ParseS16(scalarNode.Value);
                    if (_writtenIntegers.TryAdd(value.Value, scalarOffset))
                        value.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[value.Value];
                    break;
                }

            case UIFieldType.ObjectRef:
                {
                    UIObjectRef value = ParseObjectRefScalar(scalarNode.Value);
                    if (_writtenIds.TryAdd(value, scalarOffset))
                        value.Write(bs);
                    else
                        scalarOffset = _writtenIds[value];
                    break;
                }

            default:
                throw new NotSupportedException();
        }

        return scalarOffset;
    }

    private CyanStringHash ParseStringHash(string str)
    {
        if (!uint.TryParse(str, NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint value))
            return new CyanStringHash(str);
        else
            return new CyanStringHash(value);
    }

    private UIString ParseString(string str)
    {
        return new UIString(str);
    }

    private UIBool ParseBool(string str)
    {
        bool value = bool.Parse(str);

        return new UIBool(value);
    }

    private UIFloat ParseFloat(string str)
    {
        if (!float.TryParse(str, CultureInfo.InvariantCulture, out float value))
            throw new Exception("Failed to parse float");

        return new UIFloat(value);
    }

    private UI_S8 ParseS8(string str)
    {
        if (!sbyte.TryParse(str, out var value))
            throw new Exception("Failed to parse S8");

        return new UI_S8(value);
    }

    private UI_S16 ParseS16(string str)
    {
        if (!short.TryParse(str, out var value))
            throw new Exception("Failed to parse S16");

        return new UI_S16(value);
    }

    private UI_S32 ParseS32(string str)
    {
        if (!int.TryParse(str, out var value))
            throw new Exception("Failed to parse S32");

        return new UI_S32(value);
    }

    private UI_U32 ParseU32(string str)
    {
        if (!uint.TryParse(str, out var value))
            throw new Exception("Failed to parse U32");

        return new UI_U32(value);
    }

    private UIVec2 ParseVector2(string vec)
    {
        Vector2 vec2 = default;

        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 2; i++)
        {
            if (!float.TryParse(spl[i], out float value))
                throw new Exception("Failed to parse float for vec2");

            if (i == 0)
                vec2.X = value;
            else if (i == 1)
                vec2.Y = value;
        }

        return new UIVec2(vec2);
    }

    private UIVec3 ParseVector3(string vec)
    {
        Vector3 vec3 = default;

        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 3; i++)
        {
            if (!float.TryParse(spl[i], out float value))
                throw new Exception("Failed to parse float for vec3");

            if (i == 0)
                vec3.X = value;
            else if (i == 1)
                vec3.Y = value;
            else if (i == 2)
                vec3.Z = value;
        }

        return new UIVec3(vec3);
    }

    private UIVec4 ParseVector4(string vec)
    {
        Vector4 vec4 = default;

        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 4; i++)
        {
            if (!float.TryParse(spl[i], out float value))
                throw new Exception("Failed to parse float for vec4");

            if (i == 0)
                vec4.X = value;
            else if (i == 1)
                vec4.Y = value;
            else if (i == 2)
                vec4.Z = value;
            else if (i == 3)
                vec4.W = value;
        }

        return new UIVec4(vec4);
    }

    // Old
    private UIObjectRef ParseObjectRefScalar(string vec)
    {
        UIObjectRef hashAndId = new();
        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                if (!uint.TryParse(spl[i], NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint value))
                {
                    hashAndId.ComponentNameStr = spl[i];
                    hashAndId.ComponentName = XXHash32Custom.Hash(spl[i]);
                }
                else
                    hashAndId.ComponentName = value;
            }
            else
            {
                if (!short.TryParse(spl[i], out short value))
                    throw new Exception("Failed to parse uint");

                if (i == 1)
                    hashAndId.Index = value;
                else if (i == 2)
                    hashAndId.ObjectRefId = value;
            }
        }

        return hashAndId;
    }

    private UIObjectRef ParseObjectRefNode(YamlMappingNode node)
    {
        YamlScalarNode name = node["ComponentName"] as YamlScalarNode;
        YamlScalarNode index = node["Index"] as YamlScalarNode;
        YamlScalarNode objectRefId = node["ObjectRefId"] as YamlScalarNode;

        if (!short.TryParse(index.Value, out short indexValue))
            throw new Exception("Failed to parse 'Index' short for object ref");

        if (!short.TryParse(objectRefId.Value, out short objectRefIdValue))
            throw new Exception("Failed to parse 'ObjectRefId' short for object ref");

        return new UIObjectRef(name.Value, indexValue, objectRefIdValue);
    }
}
