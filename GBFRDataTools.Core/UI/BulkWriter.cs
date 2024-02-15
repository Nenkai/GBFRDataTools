using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syroot.BinaryData;
using System.Numerics;

using YamlDotNet.RepresentationModel;

using GBFRDataTools.Hashing;

namespace GBFRDataTools.Core.UI;

public class BulkWriter
{
    private Dictionary<Vector2, long> _writtenVec2s = [];
    private Dictionary<Vector3, long> _writtenVec3s = [];
    private Dictionary<Vector4, long> _writtenVec4s = [];
    private Dictionary<int, long> _writtenIntegers = [];

    private Dictionary<long, long> _hashTableToOffset = [];

    public void Write(string file, YamlNode root)
    {
        using var fs = File.Create(file);
        using var bs = new BinaryStream(fs);

        bs.Position = 0x04;

        var mapNode = root as YamlMappingNode;
        long rootTableOffset = WriteNode(bs, mapNode);
        bs.Position = 0;
        bs.WriteUInt32((uint)rootTableOffset);
    }

    private long WriteNode(BinaryStream bs, YamlNode node)
    {
        if (node is YamlMappingNode mapNode)
        {
            // Write property names hash list
            // Build the list of hashes, it'll be used as for whether to point back to a previous table
            List<uint> hashes = new List<uint>(mapNode.Children.Count);
            foreach (var childNode in mapNode.Children)
            {
                YamlScalarNode keyNode = childNode.Key as YamlScalarNode;
                if (keyNode.Value.StartsWith("_"))
                {
                    uint hash = uint.Parse(keyNode.Value[1..], System.Globalization.NumberStyles.HexNumber);
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

                for (int i = 0; i < mapNode.Children.Count; i++)
                    bs.WriteUInt32(hashes[i]);
            }

            // Write node values
            List<long> offsets = new List<long>(mapNode.Children.Count);
            foreach (var childNode in mapNode.Children)
            {
                YamlScalarNode keyNode = childNode.Key as YamlScalarNode;
                var value = childNode.Value;
                if (value is YamlMappingNode vN)
                {
                    long nodeOfs = WriteNode(bs, vN);
                    offsets.Add(nodeOfs);
                }
                else if (value is YamlSequenceNode seqNode)
                {
                    long nodeOfs = WriteSequenceElement(bs, keyNode.Value, seqNode);
                    offsets.Add(nodeOfs);
                }
                else if (value is YamlScalarNode scalarNode)
                {
                    long scalarOffset = WriteScalar(bs, keyNode.Value, scalarNode);
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

    private long WriteSequenceElement(BinaryStream bs, string keyName, YamlSequenceNode seqNode)
    {
        List<long> offsets = new List<long>(seqNode.Children.Count);

        foreach (var elem in seqNode)
        {
            if (elem is YamlScalarNode scal)
            {
                long scalarOffset = WriteScalar(bs, keyName, scal);
                offsets.Add(scalarOffset);
            }
            else
            {
                long elemOffset = WriteNode(bs, elem);
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

    private long WriteScalar(BinaryStream bs, string name, YamlScalarNode scalarNode)
    {
        uint hash;
        if (name.StartsWith('_'))
            hash = uint.Parse(name[1..], System.Globalization.NumberStyles.HexNumber);
        else
            hash = XXHash32Custom.Hash(name);

        if (!KnownProperties.List.TryGetValue(hash, out UIPropertyTypeDef def))
            throw new NotSupportedException();

        long scalarOffset = bs.Position;

        if (def.Type == FieldType.Vector2)
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
        else if (def.Type == FieldType.Vector3)
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
        else if (def.Type == FieldType.Vector4)
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
        else if (def.Type == FieldType.String || def.Type == FieldType.StringArray)
        {
            // Strings do have a length, but they're also *still* null terminated
            int length = Encoding.ASCII.GetByteCount(scalarNode.Value);
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
}
