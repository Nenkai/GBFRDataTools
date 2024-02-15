using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using Syroot.BinaryData;
using GBFRDataTools.Core.UI.Types;

namespace GBFRDataTools.Core.UI;

public class BulkReader : BinaryStream
{
    public BulkReader(Stream baseStream)
        : base(baseStream)
    {
        int rootTableOffset = ReadInt32();
        Position = rootTableOffset;
    }

    public UIObject ReadObject(Dictionary<uint, UIPropertyTypeDef> validProperties)
    {
        long off = Position;

        int tableOffset = ReadInt32();
        Position += tableOffset - sizeof(int);

        uint numEntries = ReadUInt32();
        uint[] entriesHashes = ReadUInt32s((int)numEntries);

        Position = off + 4;
        int[] objectsOffsets = ReadInt32s((int)numEntries);

        UIObject obj = new UIObject();

        for (int i = 0; i < numEntries; i++)
        {
            Position = off + objectsOffsets[i];

            if (!validProperties.TryGetValue(entriesHashes[i], out UIPropertyTypeDef propertyTypedef))
                throw new KeyNotFoundException($"Not found hash 0x{entriesHashes[i]:X8}");

            UIObjectBase prop = null;
            switch (propertyTypedef.Type)
            {
                case FieldType.Byte:
                    {
                        var @byte = new UIByte();
                        @byte.Value = this.Read1Byte();
                        prop = @byte;
                    }
                    break;
                case FieldType.UShort:
                    {
                        var @byte = new UIUShort();
                        @byte.Value = this.ReadUInt16();
                        prop = @byte;
                    }
                    break;
                case FieldType.Object:
                    prop = ReadObject(propertyTypedef.ChildProperties);
                    break;
                case FieldType.ObjectArray:
                    {
                        var arr = new UIObjectArray();
                        arr.Array = ReadObjectArray(propertyTypedef.ChildProperties);
                        prop = arr;
                    }
                    break;
                case FieldType.StringArray:
                    {
                        var arr = new UIStringArray();
                        arr.Array = ReadStringArray();
                        prop = arr;
                    }
                    break;
                case FieldType.Vector2:
                    {
                        var vec2 = new UIVec2();
                        vec2.Vector = new(ReadSingle(), ReadSingle());
                        prop = vec2;
                    }
                    break;
                case FieldType.Vector3:
                    {
                        var vec3 = new UIVec3();
                        vec3.Vector = new(ReadSingle(), ReadSingle(), ReadSingle());
                        prop = vec3;
                    }
                    break;
                case FieldType.Vector4:
                    {
                        var vec4 = new UIVec4();
                        vec4.Vector = new(ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle());
                        prop = vec4;
                    }
                    break;
                case FieldType.String:
                    {
                        var str = new UIString();
                        str.Str = this.ReadString(StringCoding.Int32CharCount); 
                        prop = str;
                    }
                    break;
                case FieldType.Float:
                    {
                        var @float = new UIFloat();
                        @float.Value = this.ReadSingle();
                        prop = @float;
                    }
                    break;
                case FieldType.Bool:
                    {
                        var @bool = new UIBool();
                        @bool.Value = this.ReadBoolean();
                        prop = @bool;
                    }
                    break;
                case FieldType.UInt:
                    {
                        var @uint = new UIUInt();
                        @uint.Value = this.ReadUInt32();
                        prop = @uint;
                    }
                    break;
                case FieldType.IntArray:
                    {
                        var arr = new UIIntArray();
                        arr.Array = ReadIntArray();
                        prop = arr;
                    }
                    break;
                case FieldType.HashAndId:
                    {
                        var @uint = new UIHashAndId();
                        @uint.Hash = this.ReadUInt32();
                        @uint.Unk1 = this.ReadInt16();
                        @uint.Unk2 = this.ReadInt16();
                        prop = @uint;
                    }
                    break;
                case FieldType.HashAndIdArray:
                    {
                        var arr = new UIHashAndIdArray();
                        arr.Array = ReadHashOrIdArray();
                        prop = arr;
                    }
                    break;
                default:
                    throw new NotSupportedException("Not supported type");
            }
            prop.Name = propertyTypedef.Name;

            obj.Children.Add(prop);
        }

        return obj;
    }

    public List<UIObjectBase> ReadObjectArray(Dictionary<uint, UIPropertyTypeDef> validProperties)
    {
        long baseOfs = Position;
        uint arrayLength = ReadUInt32();
        int[] objectsOffsets = ReadInt32s((int)arrayLength);

        List<UIObjectBase> objects = new List<UIObjectBase>();

        for (int i = 0; i < objectsOffsets.Length;i++)
        {
            Position = baseOfs + objectsOffsets[i];

            var obj = ReadObject(validProperties);
            objects.Add(obj);
        }

        return objects;
    }

    public List<string> ReadStringArray()
    {
        long baseOfs = Position;
        uint arrayLength = ReadUInt32();
        int[] objectsOffsets = ReadInt32s((int)arrayLength);

        List<string> objects = new List<string>();

        for (int i = 0; i < objectsOffsets.Length; i++)
        {
            Position = baseOfs + objectsOffsets[i];

            string str = this.ReadString(StringCoding.Int32CharCount);
            objects.Add(str);
        }

        return objects;
    }

    public List<int> ReadIntArray()
    {
        long baseOfs = Position;
        uint arrayLength = ReadUInt32();
        int[] objectsOffsets = ReadInt32s((int)arrayLength);

        List<int> objects = new List<int>();

        for (int i = 0; i < objectsOffsets.Length; i++)
        {
            Position = baseOfs + objectsOffsets[i];
            objects.Add(ReadInt32());
        }

        return objects;
    }

    public List<UIHashAndId> ReadHashOrIdArray()
    {
        long baseOfs = Position;
        uint arrayLength = ReadUInt32();
        int[] objectsOffsets = ReadInt32s((int)arrayLength);

        List<UIHashAndId> objects = new List<UIHashAndId>();

        for (int i = 0; i < objectsOffsets.Length; i++)
        {
            var obj = new UIHashAndId();
            Position = baseOfs + objectsOffsets[i];
            obj.Hash = this.ReadUInt32();
            obj.Unk1 = this.ReadInt16();
            obj.Unk2 = this.ReadInt16();
            objects.Add(obj);

        }

        return objects;
    }
}
