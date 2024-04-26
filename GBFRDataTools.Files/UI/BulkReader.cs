using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

using Syroot.BinaryData;
using GBFRDataTools.Files.UI.Types;
using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.UI;

public class BulkReader : BinaryStream
{
    public BulkReader(Stream baseStream)
        : base(baseStream)
    {
        int rootTableOffset = ReadInt32();
        Position = rootTableOffset;
    }

    public UIObject ReadObject(List<UIPropertyTypeDef> validProperties)
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
            Dictionary<uint, UIPropertyTypeDef> validPropertiesDict = validProperties.ToDictionary(e => e.Hash);
            if (!validPropertiesDict.TryGetValue(entriesHashes[i], out UIPropertyTypeDef propertyTypedef))
                throw new KeyNotFoundException($"Not found hash 0x{entriesHashes[i]:X8}");

            string compName = null;
            List<UIPropertyTypeDef> childProperties = propertyTypedef.ChildProperties;
            if (propertyTypedef.Name.Equals("Component"))
            {
                int compNameIndex = Array.IndexOf(entriesHashes, Hashing.XXHash32Custom.Hash("ComponentName"));
                if (compNameIndex == -1)
                    throw new KeyNotFoundException("Missing 'ComponentName' property in Components array.");

                Position = off + objectsOffsets[compNameIndex];
                compName = ReadBulkString();

                if (!KnownProperties.ComponentList.TryGetValue(compName, out childProperties))
                    throw new KeyNotFoundException($"Unmapped/Unsupported component type '{compName}'. " +
                        $"This is not a bug - this file contains UI components that are not yet supported.");
            }

            Position = off + objectsOffsets[i];

            UIObjectBase prop = null;
            switch (propertyTypedef.Type)
            {
                case FieldType.S8:
                    {
                        var @byte = new UI_S8();
                        @byte.Value = this.ReadSByte();
                        prop = @byte;
                    }
                    break;
                case FieldType.S16:
                    {
                        var @byte = new UI_S16();
                        @byte.Value = this.ReadInt16();
                        prop = @byte;
                    }
                    break;
                case FieldType.S32:
                    {
                        var @byte = new UI_S32();
                        @byte.Value = this.ReadInt32();
                        prop = @byte;
                    }
                    break;
                case FieldType.Object:
                    prop = ReadObject(childProperties);
                    break;
                case FieldType.ObjectArray:
                    {
                        var arr = new UIObjectArray();
                        arr.Array = ReadObjectArray(childProperties);
                        prop = arr;
                    }
                    break;
                case FieldType.StringVector:
                    {
                        var arr = new UIStringArray();
                        arr.Array = ReadStringArray();
                        prop = arr;
                    }
                    break;
                case FieldType.CVec2:
                    {
                        var vec2 = new UIVec2();
                        vec2.Vector = new(ReadSingle(), ReadSingle());
                        prop = vec2;
                    }
                    break;
                case FieldType.CVec3:
                    {
                        var vec3 = new UIVec3();
                        vec3.Vector = new(ReadSingle(), ReadSingle(), ReadSingle());
                        prop = vec3;
                    }
                    break;
                case FieldType.CVec4:
                    {
                        var vec4 = new UIVec4();
                        vec4.Vector = new(ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle());
                        prop = vec4;
                    }
                    break;
                case FieldType.String:
                    {
                        var str = new UIString();
                        str.Str = ReadBulkString();
                        prop = str;
                    }
                    break;
                case FieldType.F32:
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
                case FieldType.CyanStringHash:
                    {
                        var @uint = new CyanStringHash();
                        @uint.Value = this.ReadUInt32();
                        prop = @uint;
                    }
                    break;
                case FieldType.S32Vector:
                    {
                        var arr = new UIIntArray();
                        arr.Array = ReadIntArray();
                        prop = arr;
                    }
                    break;
                case FieldType.ObjectRef:
                    {
                        var @uint = new UIHashAndId();
                        @uint.Hash = this.ReadUInt32();
                        @uint.Unk1 = this.ReadInt16();
                        @uint.Unk2 = this.ReadInt16();
                        prop = @uint;
                    }
                    break;
                case FieldType.ObjectRefVector:
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

    public List<UIObjectBase> ReadObjectArray(List<UIPropertyTypeDef> validProperties)
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

            string str = ReadBulkString();
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

    public string ReadBulkString()
    {
        int strByteLength = this.ReadInt32();
        byte[] bytes = new byte[strByteLength];
        this.Read(bytes);

        return Encoding.UTF8.GetString(bytes);
    }
}
