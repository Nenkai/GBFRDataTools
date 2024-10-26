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
using System.Collections.ObjectModel;

namespace GBFRDataTools.Files.UI;

public class BulkReader : BinaryStream
{
    public BulkReader(Stream baseStream)
        : base(baseStream)
    {
        int rootTableOffset = ReadInt32();
        Position = rootTableOffset;

        _knownStringHashes.Add(XXHash32Custom.Hash(""), "");
    }

    private Dictionary<uint, string> _knownStringHashes = [];
    public IReadOnlyDictionary<uint, string> KnownStringHashes => new ReadOnlyDictionary<uint, string>(_knownStringHashes);

    public UIObject ReadRootObject()
    {
        var root = ReadObject(KnownProperties.List);
        ResolveHashReferencesRecursive(root);
        return root;
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

        // De-bsearch order every entry, but reorder them based on our defined order (which is more accurate & clearer)
        List<uint> reorderedHashes = [];
        List<int> reorderedOffsets = [];
        List<uint> unknownHashes = entriesHashes.ToList();
        foreach (var elem in validProperties)
        {
            int indexOfElem = Array.IndexOf(entriesHashes, elem.Hash);
            if (indexOfElem != -1)
            {
                reorderedHashes.Add(entriesHashes[indexOfElem]);
                reorderedOffsets.Add(objectsOffsets[indexOfElem]);
                unknownHashes.Remove(entriesHashes[indexOfElem]);
            }
        }

        foreach (var remainingElem in unknownHashes)
        {
            int indexOfElem = Array.IndexOf(entriesHashes, remainingElem);
            reorderedHashes.Add(remainingElem);
            reorderedOffsets.Add(objectsOffsets[indexOfElem]);
        }

        // Actually go through em
        for (int i = 0; i < numEntries; i++)
        {
            Dictionary<uint, UIPropertyTypeDef> validPropertiesDict = validProperties.ToDictionary(e => e.Hash);
            if (!validPropertiesDict.TryGetValue(reorderedHashes[i], out UIPropertyTypeDef propertyTypedef))
            {
                if (UIPropertyTypeDef.HashToPropName.TryGetValue(reorderedHashes[i], out string name))
                    throw new KeyNotFoundException($"Not found hash 0x{reorderedHashes[i]:X8} (hint: name is {name})");
                else
                    throw new KeyNotFoundException($"Not found hash 0x{reorderedHashes[i]:X8}");
            }

            string compName = null;
            List<UIPropertyTypeDef> childProperties = propertyTypedef.ChildProperties;
            if (propertyTypedef.Name.Equals("Component"))
            {
                int compNameIndex = reorderedHashes.IndexOf(XXHash32Custom.Hash("ComponentName"));
                if (compNameIndex == -1)
                    throw new KeyNotFoundException("Missing 'ComponentName' property in Components array.");

                Position = off + objectsOffsets[compNameIndex];
                compName = ReadBulkString();

                if (!KnownProperties.ComponentList.TryGetValue(compName, out childProperties))
                    throw new KeyNotFoundException($"Unmapped/Unsupported component type '{compName}'. " +
                        $"This is not a bug - this file contains UI components that are not yet supported.");
            }

            Position = off + reorderedOffsets[i];

            UIObjectBase prop = null;
            switch (propertyTypedef.Type)
            {
                case UIFieldType.S8:
                    {
                        var @byte = new UI_S8();
                        @byte.Value = this.ReadSByte();
                        prop = @byte;
                    }
                    break;
                case UIFieldType.S16:
                    {
                        var @byte = new UI_S16();
                        @byte.Value = this.ReadInt16();
                        prop = @byte;
                    }
                    break;
                case UIFieldType.S32:
                    {
                        var @byte = new UI_S32();
                        @byte.Value = this.ReadInt32();
                        prop = @byte;
                    }
                    break;
                case UIFieldType.U32:
                    {
                        var uint32 = new UI_U32();
                        uint32.Value = this.ReadUInt32();
                        prop = uint32;
                    }
                    break;
                case UIFieldType.Object:
                    prop = ReadObject(childProperties);
                    break;
                case UIFieldType.ObjectArray:
                    {
                        var arr = new UIObjectArray();
                        arr.Array = ReadObjectArray(childProperties);
                        prop = arr;
                    }
                    break;
                case UIFieldType.StringVector:
                    {
                        var arr = new UIStringArray();
                        arr.Array = ReadStringArray();
                        prop = arr;
                    }
                    break;
                case UIFieldType.CVec2:
                    {
                        var vec2 = new UIVec2();
                        vec2.Vector = new(ReadSingle(), ReadSingle());
                        prop = vec2;
                    }
                    break;
                case UIFieldType.CVec3:
                    {
                        var vec3 = new UIVec3();
                        vec3.Vector = new(ReadSingle(), ReadSingle(), ReadSingle());
                        prop = vec3;
                    }
                    break;
                case UIFieldType.CVec4:
                    {
                        var vec4 = new UIVec4();
                        vec4.Vector = new(ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle());
                        prop = vec4;
                    }
                    break;
                case UIFieldType.String:
                    {
                        var str = new UIString();
                        str.Str = ReadBulkString();
                        prop = str;
                    }
                    break;
                case UIFieldType.F32:
                    {
                        var @float = new UIFloat();
                        @float.Value = this.ReadSingle();
                        prop = @float;
                    }
                    break;
                case UIFieldType.Bool:
                    {
                        var @bool = new UIBool();
                        @bool.Value = this.ReadBoolean();
                        prop = @bool;
                    }
                    break;
                case UIFieldType.CyanStringHash:
                    {
                        var @uint = new CyanStringHash();
                        @uint.Hash = this.ReadUInt32();
                        prop = @uint;
                    }
                    break;
                case UIFieldType.S32Vector:
                    {
                        var arr = new UIIntArray();
                        arr.Array = ReadIntArray();
                        prop = arr;
                    }
                    break;
                case UIFieldType.ObjectRef:
                    {
                        var @uint = new UIObjectRef();
                        @uint.ComponentName = this.ReadUInt32();
                        @uint.Index = this.ReadInt16();
                        @uint.ObjectRefId = this.ReadInt16();
                        prop = @uint;
                    }
                    break;
                case UIFieldType.ObjectRefVector:
                    {
                        var arr = new UIObjectRefArray();
                        arr.Array = ReadObjectRefArray();
                        prop = arr;
                    }
                    break;
                default:
                    throw new NotSupportedException("Not supported type");
            }
            prop.Name = propertyTypedef.Name;

            obj.Children.Add(prop.Name, prop);
        }

        return obj;
    }

    /// <summary>
    /// Tries to resolve all hashes for ObjectRef elements. This should be called if not using <see cref="ResolveHashReferencesRecursive(UIObject)"./>
    /// </summary>
    /// <param name="uiObj"></param>
    public void ResolveHashReferencesRecursive(UIObject uiObj)
    {
        foreach (UIObjectBase child in uiObj.Children.Values)
        {
            switch (child)
            {
                case UIObjectRef objRef:
                    {
                        if (_knownStringHashes.TryGetValue(objRef.ComponentName, out string str))
                            objRef.ComponentNameStr = str;
                    }
                    break;

                case UIObjectRefArray objRefArray:
                    {
                        foreach (UIObjectRef @ref in objRefArray.Array)
                        {
                            if (_knownStringHashes.TryGetValue(@ref.ComponentName, out string str))
                                @ref.ComponentNameStr = str;
                        }
                    }
                    break;

                case UIObject obj:
                    ResolveHashReferencesRecursive(obj);
                    break;

                case UIObjectArray objArray:
                    {
                        foreach (var @childObj in objArray.Array)
                        {
                            if (childObj is UIObject)
                                ResolveHashReferencesRecursive(@childObj as UIObject);
                        }
                    }
                    break;

                case CyanStringHash hash:
                    {
                        if (KnownProperties.HashToSpriteName.TryGetValue(hash.Hash, out string str))
                            hash.String = str;
                        else if (_knownStringHashes.TryGetValue(hash.Hash, out str))
                            hash.String = str;
                    }
                    break;
            }
        }
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

    public List<UIObjectRef> ReadObjectRefArray()
    {
        long baseOfs = Position;
        uint arrayLength = ReadUInt32();
        int[] objectsOffsets = ReadInt32s((int)arrayLength);

        List<UIObjectRef> objects = new List<UIObjectRef>();

        for (int i = 0; i < objectsOffsets.Length; i++)
        {
            var obj = new UIObjectRef();
            Position = baseOfs + objectsOffsets[i];
            obj.ComponentName = this.ReadUInt32();
            obj.Index = this.ReadInt16();
            obj.ObjectRefId = this.ReadInt16();
            objects.Add(obj);

        }

        return objects;
    }

    public string ReadBulkString()
    {
        int strByteLength = this.ReadInt32();
        byte[] bytes = new byte[strByteLength];
        this.Read(bytes);

        string str = Encoding.UTF8.GetString(bytes);
        _knownStringHashes.TryAdd(XXHash32Custom.Hash(str), str);
        return str;
    }
}
