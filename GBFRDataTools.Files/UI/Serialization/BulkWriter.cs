using GBFRDataTools.Files.UI.Types;
using GBFRDataTools.Hashing;

using Syroot.BinaryData;

using System.Collections;
using System.Globalization;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Serialization;

public class BulkWriter
{
    // "Bulk" files are pretty interesting. Cy uses yaml as input format, and then they get converted into this weird, binary like, hierarchy.
    // Properties for each object are stored as hashes (of name). 
    // Offsets to data may be negative and seek back to a previous position.
    // NAMELY data is deduped wherever possible! Including references to complex objects.

    // TODO: Here we simply keep track of written scalar types, but in the future we should also somehow track previously written objects.
    // That would help drastically drop the file sizes.
    // For now we keep track of cVec2, cVec3, cVec4, ints, floats and object refs.

    private Dictionary<Vector2, long> _writtenVec2s = [];
    private Dictionary<Vector3, long> _writtenVec3s = [];
    private Dictionary<Vector4, long> _writtenVec4s = [];
    private Dictionary<int, long> _writtenIntegers = [];
    private Dictionary<float, long> _writtenFloats = [];
    private Dictionary<UIObjectRef, long> _writtenIds = [];

    // Oh yeah hash tables themselves may be pointed back to aswell. Track these.
    private Dictionary<long, long> _hashedTableHashesToOffset = [];

    public void Write(string file, object value)
    {
        using var fs = File.Create(file);
        using var bs = new BinaryStream(fs);

        bs.Position = 0x04;

        long rootTableOffset = WriteObject(bs, value);
        bs.Position = 0;
        bs.WriteUInt32((uint)rootTableOffset);
    }

    private long WriteObject(BinaryStream bs, object value)
    {
        Type type = value.GetType();
        var reflectedType = UIComponentSerializationCache.GetOrRegisterType(type.Name);

        // Write property names hash list
        // Build the list of hashes, it'll be used as for whether to point back to a previous table
        List<uint> propertyHashes = new(reflectedType.Properties.Count);

        // Get all properties, order for bsearch
        List<UIPropertyTypeDef> orderedProperties = reflectedType.Properties.OrderBy(e => e.Hash).ToList();
        for (int i = 0; i < orderedProperties.Count; i++)
        {
            UIPropertyTypeDef prop = orderedProperties[i];
            var propValue = prop.PropertyInfo.GetValue(value);
            propertyHashes.Add(prop.Hash);
        }

        // Filter all properties where values are null/default
        for (int i = orderedProperties.Count-1; i >= 0; i--)
        {
            UIPropertyTypeDef prop = orderedProperties[i];
            var propValue = prop.PropertyInfo.GetValue(value);
            if (propValue is null)
            {
                orderedProperties.Remove(prop);
                propertyHashes.Remove(prop.Hash);
            }
        }

        // Hash tables for each properties are tracked by computing a quick sum
        // This is mainly to allow pointing to an identical hash table (same number of properties, same properties)
        // that may have been used by another object
        long hashTableHash = 0;
        for (int i = 0; i < propertyHashes.Count; i++)
            hashTableHash = HashCode.Combine(hashTableHash, propertyHashes[i]);

        if (!_hashedTableHashesToOffset.TryGetValue(hashTableHash, out long propTableOffset))
        {
            propTableOffset = bs.Position;

            _hashedTableHashesToOffset.Add(hashTableHash, bs.Position);
            bs.WriteUInt32((uint)propertyHashes.Count);

            for (int i = 0; i < propertyHashes.Count; i++)
                bs.WriteUInt32(propertyHashes[i]);
        }

        // Write node values
        List<long> offsets = new(orderedProperties.Count);
        foreach (var property in orderedProperties)
        {
            var propValue = property.PropertyInfo.GetValue(value);
            if (property.IsArray)
            {
                long nodeOfs = WriteArrayElement(bs, propValue, property);
                offsets.Add(nodeOfs);
            }
            else if (property.Type == UIFieldType.Object)
            {
                long nodeOfs = WriteObject(bs, propValue);
                offsets.Add(nodeOfs);
            }
            else
            {
                long scalarOffset = WriteScalar(bs, propValue, property);
                offsets.Add(scalarOffset);
            }
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

    private long WriteArrayElement(BinaryStream bs, object value, UIPropertyTypeDef elemTypeDef)
    {
        IList list = (IList)value;

        List<long> offsets = new(list.Count);
        foreach (var elem in list)
        {
            long elemOffset;
            if (elemTypeDef.Type == UIFieldType.Object)
            {
                elemOffset = WriteObject(bs, elem);
            }
            else
            {
                elemOffset = WriteScalar(bs, elem, elemTypeDef);
            }

            offsets.Add(elemOffset);
        }

        long baseOfs = bs.Position;
        bs.WriteUInt32((uint)list.Count);
        for (int i = 0; i < list.Count; i++)
        {
            long actual = (int)(offsets[i] - baseOfs);
            bs.WriteInt32((int)actual);
        }

        return baseOfs;
    }

    private long WriteScalar(BinaryStream bs, object value, UIPropertyTypeDef propertyDef)
    {
        long scalarOffset = bs.Position;

        switch (propertyDef.Type)
        {
            case UIFieldType.CVec2:
                {
                    Vector2 vec2 = (Vector2)value;
                    if (_writtenVec2s.TryAdd(vec2, scalarOffset))
                    {
                        bs.WriteSingle(vec2.X);
                        bs.WriteSingle(vec2.Y);
                    }
                    else
                        scalarOffset = _writtenVec2s[vec2];
                    break;
                }

            case UIFieldType.CVec3:
                {
                    Vector3 vec3 = (Vector3)value;
                    if (_writtenVec3s.TryAdd(vec3, scalarOffset))
                    {
                        bs.WriteSingle(vec3.X);
                        bs.WriteSingle(vec3.Y);
                        bs.WriteSingle(vec3.Z);
                    }
                    else
                        scalarOffset = _writtenVec3s[vec3];
                    break;
                }

            case UIFieldType.CVec4:
                {
                    Vector4 vec4 = (Vector4)value;
                    if (_writtenVec4s.TryAdd(vec4, scalarOffset))
                    {
                        bs.WriteSingle(vec4.X);
                        bs.WriteSingle(vec4.Y);
                        bs.WriteSingle(vec4.Z);
                        bs.WriteSingle(vec4.W);
                    }
                    else
                        scalarOffset = _writtenVec4s[vec4];
                    break;
                }

            case UIFieldType.String:
                {
                    string str = (string)value;
                    int length = Encoding.UTF8.GetByteCount(str);
                    bs.WriteInt32(length);
                    bs.WriteString(str, StringCoding.ZeroTerminated);
                    break;
                }

            case UIFieldType.Bool:
                {
                    bool boolValue = (bool)value;
                    if (_writtenIntegers.TryAdd(boolValue ? 1 : 0, scalarOffset))
                        bs.WriteBoolean(boolValue, BooleanCoding.Dword);
                    else
                        scalarOffset = _writtenIntegers[boolValue ? 1 : 0]; // We align so it's fine to shove there
                    break;
                }
            case UIFieldType.S32:
                {
                    int intValue = (int)value;
                    if (_writtenIntegers.TryAdd(intValue, scalarOffset))
                        bs.WriteInt32(intValue);
                    else
                        scalarOffset = _writtenIntegers[intValue];
                    break;
                }

            case UIFieldType.U32:
                {
                    uint uintValue = (uint)value;
                    if (_writtenIntegers.TryAdd((int)uintValue, scalarOffset))
                        bs.WriteUInt32(uintValue);
                    else
                        scalarOffset = _writtenIntegers[(int)uintValue];
                    break;
                }

            case UIFieldType.CyanStringHash:
                {
                    CyanStringHash hash = (CyanStringHash)value;
                    if (_writtenIntegers.TryAdd((int)hash.Hash, scalarOffset))
                        hash.Write(bs);
                    else
                        scalarOffset = _writtenIntegers[(int)hash.Hash];
                    break;
                }

            case UIFieldType.F32:
                {
                    float @float = (float)value;
                    if (_writtenFloats.TryAdd(@float, scalarOffset))
                        bs.WriteSingle(@float);
                    else
                        scalarOffset = _writtenFloats[@float];
                    break;
                }

            case UIFieldType.S8:
                {
                    sbyte sbyteValue = (sbyte)value;
                    if (_writtenIntegers.TryAdd(sbyteValue, scalarOffset))
                        bs.WriteSByte(sbyteValue);
                    else
                        scalarOffset = _writtenIntegers[sbyteValue]; // We align so it's fine to shove there
                    break;
                }

            case UIFieldType.S16:
                {
                    short shortValue = (short)value;
                    if (_writtenIntegers.TryAdd(shortValue, scalarOffset))
                    {
                        bs.WriteInt16(shortValue);
                    }
                    else
                        scalarOffset = _writtenIntegers[shortValue]; // We align so it's fine to shove there
                    break;
                }

            case UIFieldType.ObjectRef:
                {
                    UIObjectRef objectRef = (UIObjectRef)value;
                    if (_writtenIds.TryAdd(objectRef, scalarOffset))
                        objectRef.Write(bs);
                    else
                        scalarOffset = _writtenIds[objectRef];
                    break;
                }

            default:
                throw new NotSupportedException("Not supported type");
        }

        bs.Align(0x04, grow: true);
        return scalarOffset;
    }
}