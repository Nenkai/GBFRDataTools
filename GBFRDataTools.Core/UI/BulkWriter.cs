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

namespace GBFRDataTools.Files.UI;

public class BulkWriter
{
    private Dictionary<Vector2, long> _writtenVec2s = [];
    private Dictionary<Vector3, long> _writtenVec3s = [];
    private Dictionary<Vector4, long> _writtenVec4s = [];
    private Dictionary<int, long> _writtenIntegers = [];
    private Dictionary<float, long> _writtenFloats = [];
    private Dictionary<UIHashAndId, long> _writtenIds = [];

    private Dictionary<long, long> _hashTableToOffset = [];

    public void Write(string file, YamlNode root)
    {
        using var fs = File.Create(file);
        using var bs = new BinaryStream(fs);

        bs.Position = 0x04;

        var mapNode = root as YamlMappingNode;
        long rootTableOffset = WriteNode(bs, mapNode, KnownProperties.List);
        bs.Position = 0;
        bs.WriteUInt32((uint)rootTableOffset);
    }

    private long WriteNode(BinaryStream bs, YamlNode node, List<UIPropertyTypeDef> validProperties)
    {
        if (node is YamlMappingNode mapNode)
        {
            // Write property names hash list
            // Build the list of hashes, it'll be used as for whether to point back to a previous table
            List<uint> hashes = new List<uint>(mapNode.Children.Count);

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
            List<long> offsets = new List<long>(mapNode.Children.Count);
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
                if (value is YamlMappingNode vN)
                {
                    long nodeOfs = WriteNode(bs, vN, childProperties);
                    offsets.Add(nodeOfs);
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

    private long WriteSequenceElement(BinaryStream bs, YamlSequenceNode seqNode, List<UIPropertyTypeDef> validProperties, UIPropertyTypeDef scalarDef)
    {
        List<long> offsets = new List<long>(seqNode.Children.Count);

        foreach (var elem in seqNode)
        {
            if (elem is YamlScalarNode scal)
            {
                long scalarOffset = WriteScalar(bs, scal, scalarDef);
                offsets.Add(scalarOffset);
            }
            else
            {
                long elemOffset = WriteNode(bs, elem, validProperties);
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

    private long WriteScalar(BinaryStream bs, YamlScalarNode scalarNode, UIPropertyTypeDef def)
    {
        long scalarOffset = bs.Position;

        if (def.Type == FieldType.CVec2)
        {
            Vector2 vec2 = ParseVector2(scalarNode.Value);
            if (_writtenVec2s.TryAdd(vec2, scalarOffset))
            {
                bs.WriteSingle(vec2.X);
                bs.WriteSingle(vec2.Y);
            }
            else
                scalarOffset = _writtenVec2s[vec2];
        }
        else if (def.Type == FieldType.CVec3)
        {
            Vector3 vec3 = ParseVector3(scalarNode.Value);
            if (_writtenVec3s.TryAdd(vec3, scalarOffset))
            {
                bs.WriteSingle(vec3.X);
                bs.WriteSingle(vec3.Y);
                bs.WriteSingle(vec3.Z);
            }
            else
                scalarOffset = _writtenVec3s[vec3];
        }
        else if (def.Type == FieldType.CVec4)
        {
            Vector4 vec4 = ParseVector4(scalarNode.Value);
            if (_writtenVec4s.TryAdd(vec4, scalarOffset))
            {
                bs.WriteSingle(vec4.X);
                bs.WriteSingle(vec4.Y);
                bs.WriteSingle(vec4.Z);
                bs.WriteSingle(vec4.W);
            }
            else
                scalarOffset = _writtenVec4s[vec4];
        }
        else if (def.Type == FieldType.String || def.Type == FieldType.StringVector)
        {
            // Strings do have a length, but they're also *still* null terminated
            int length = Encoding.UTF8.GetByteCount(scalarNode.Value);
            bs.WriteInt32(length);
            bs.WriteString(scalarNode.Value, StringCoding.ZeroTerminated);

            // Therefore, padding occurs after temination anyway
            bs.Align(0x04, grow: true);
        }
        else if (def.Type == FieldType.Bool)
        {
            int value = bool.Parse(scalarNode.Value) ? 1 : 0;
            if (_writtenIntegers.TryAdd(value, scalarOffset))
                bs.WriteInt32(value);
            else
                scalarOffset = _writtenIntegers[value];
        }
        else if (def.Type == FieldType.S32Vector)
        {
            int value = int.Parse(scalarNode.Value);
            if (_writtenIntegers.TryAdd(value, scalarOffset))
                bs.WriteInt32(value);
            else
                scalarOffset = _writtenIntegers[value];
        }
        else if (def.Type == FieldType.S32)
        {
            int value = int.Parse(scalarNode.Value);
            if (_writtenIntegers.TryAdd(value, scalarOffset))
                bs.WriteInt32(value);
            else
                scalarOffset = _writtenIntegers[value];
        }
        else if (def.Type == FieldType.CyanStringHash)
        {
            uint value = uint.Parse(scalarNode.Value, NumberStyles.HexNumber);
            if (_writtenIntegers.TryAdd((int)value, scalarOffset))
                bs.WriteUInt32(value);
            else
                scalarOffset = _writtenIntegers[(int)value];
        }
        else if (def.Type == FieldType.F32)
        {
            float value = float.Parse(scalarNode.Value);
            if (_writtenFloats.TryAdd(value, scalarOffset))
                bs.WriteSingle(value);
            else
                scalarOffset = _writtenFloats[value];
        }
        else if (def.Type == FieldType.S8)
        {
            int value = sbyte.Parse(scalarNode.Value);
            if (_writtenIntegers.TryAdd(value, scalarOffset))
                bs.WriteInt32(value);
            else
                scalarOffset = _writtenIntegers[value];
        }
        else if (def.Type == FieldType.S16)
        {
            short value = short.Parse(scalarNode.Value);
            if (_writtenIntegers.TryAdd(value, scalarOffset))
                bs.WriteInt32(value);
            else
                scalarOffset = _writtenIntegers[value];
        }
        else if (def.Type == FieldType.ObjectRef || def.Type == FieldType.ObjectRefVector)
        {
            UIHashAndId value = ParseHashAndId(scalarNode.Value);
            if (_writtenIds.TryAdd(value, scalarOffset))
            {
                bs.WriteUInt32(value.Hash);
                bs.WriteInt16(value.Unk1);
                bs.WriteInt16(value.Unk2);
            }
            else
                scalarOffset = _writtenIds[value];
        }
        else
            throw new NotSupportedException();

        return scalarOffset;
    }

    private Vector2 ParseVector2(string vec)
    {
        Vector2 vec2 = default;

        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 2; i++)
        {
            if (!float.TryParse(spl[i], out float value))
                throw new Exception("Failed to parse float");

            if (i == 0)
                vec2.X = value;
            else if (i == 1)
                vec2.Y = value;
        }

        return vec2;
    }

    private Vector3 ParseVector3(string vec)
    {
        Vector3 vec3 = default;

        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 3; i++)
        {
            if (!float.TryParse(spl[i], out float value))
                throw new Exception("Failed to parse float");

            if (i == 0)
                vec3.X = value;
            else if (i == 1)
                vec3.Y = value;
            else if (i == 2)
                vec3.Z = value;
        }

        return vec3;
    }

    private Vector4 ParseVector4(string vec)
    {
        Vector4 vec4 = default;

        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 4; i++)
        {
            if (!float.TryParse(spl[i], out float value))
                throw new Exception("Failed to parse float");

            if (i == 0)
                vec4.X = value;
            else if (i == 1)
                vec4.Y = value;
            else if (i == 2)
                vec4.Z = value;
            else if (i == 3)
                vec4.W = value;
        }

        return vec4;
    }

    private UIHashAndId ParseHashAndId(string vec)
    {
        UIHashAndId hashAndId = new();
        string[] spl = vec.Split(',', StringSplitOptions.TrimEntries);
        for (int i = 0; i < 3; i++)
        {
            if (i == 0)
            {
                if (!uint.TryParse(spl[i], NumberStyles.HexNumber, CultureInfo.CurrentCulture, out uint value))
                    throw new Exception("Failed to parse hash");

                hashAndId.Hash = value;
            }
            else
            {
                if (!short.TryParse(spl[i], out short value))
                    throw new Exception("Failed to parse uint");

                if (i == 1)
                    hashAndId.Unk1 = value;
                else if (i == 2)
                    hashAndId.Unk2 = value;
            }
        }

        return hashAndId;
    }
}
