using GBFRDataTools.Files.UI.Assets;
using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Files.UI.Types;
using GBFRDataTools.Hashing;

using Syroot.BinaryData;

using System.Collections;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;
using System.Text;

namespace GBFRDataTools.Files.UI.Serialization;

public class BulkReader : BinaryStream
{
    private string _parentName;

    public BulkReader(Stream baseStream)
        : base(baseStream)
    {
        int rootTableOffset = ReadInt32();
        Position = rootTableOffset;

    }

    public T ReadObject<T>() where T : new()
    {
        long baseOffset = Position;

        int tableOffset = ReadInt32();
        Position += tableOffset - sizeof(int);

        uint numProperties = ReadUInt32();
        uint[] propertiesHashes = ReadUInt32s((int)numProperties);

        Position = baseOffset + 4;
        int[] propertiesOffsets = ReadInt32s((int)numProperties);

        // De-bsearch order every entry, but reorder them based on our defined order (which is more accurate & clearer)
        List<uint> reorderedHashes = [];
        List<int> reorderedOffsets = [];
        List<uint> unknownHashes = propertiesHashes.ToList();

        T newObj = new();
        Type type = typeof(T);
        UIComponentReflectedType? reflectedType = UIComponentSerializationCache.GetOrRegisterType(type.Name);
        if (reflectedType is null)
            throw new KeyNotFoundException($"Unmapped/Unsupported component type '{type.Name}'. " +
                $"This is not a bug - this file contains UI components that are not yet supported.");

        foreach (UIPropertyTypeDef property in reflectedType.Properties)
        {
            int indexOfElem = Array.IndexOf(propertiesHashes, property.Hash);
            if (indexOfElem != -1)
            {
                reorderedHashes.Add(propertiesHashes[indexOfElem]);
                reorderedOffsets.Add(propertiesOffsets[indexOfElem]);
                unknownHashes.Remove(propertiesHashes[indexOfElem]);
            }
        }

        foreach (var remainingElem in unknownHashes)
        {
            int indexOfElem = Array.IndexOf(propertiesHashes, remainingElem);
            reorderedHashes.Add(remainingElem);
            reorderedOffsets.Add(propertiesOffsets[indexOfElem]);
        }

        // Actually go through em
        for (int i = 0; i < numProperties; i++)
        {
            Dictionary<uint, UIPropertyTypeDef> validPropertiesDict = reflectedType.Properties.ToDictionary(e => e.Hash);

            string compName = null;

            // Object types have ComponentName that determine the type of Component.
            if (typeof(T) == typeof(Assets.Object) && reorderedHashes[i] == XXHash32Custom.Hash("Components"))
            {
                int componentsIndex = reorderedHashes.IndexOf(XXHash32Custom.Hash("Components"));
                validPropertiesDict.TryGetValue(reorderedHashes[i], out UIPropertyTypeDef componentsPropertyDef);

                Position = baseOffset + reorderedOffsets[componentsIndex];
                List<ComponentThing> components = ReadComponentList<T>();

                componentsPropertyDef.PropertyInfo.SetValue(newObj, components);
                continue;
            }

            if (!validPropertiesDict.TryGetValue(reorderedHashes[i], out UIPropertyTypeDef propertyTypedef))
            {
                if (UIComponentSerializationCache.KnownHashNames.TryGetValue(reorderedHashes[i], out string name))
                    throw new KeyNotFoundException($"Unrecognized property with hash 0x{reorderedHashes[i]:X8} in '{reflectedType.Name}' (hint: name is {name})");
                else
                    throw new KeyNotFoundException($"Unrecognized property with hash 0x{reorderedHashes[i]:X8} in '{reflectedType.Name}'");
            }

            Position = baseOffset + reorderedOffsets[i];

            if (propertyTypedef.IsArray)
            {
                switch (propertyTypedef.Type)
                {
                    case UIFieldType.String:
                        List<string> strings = [];
                        ReadArray(() => strings.Add(ReadBulkString()));
                        propertyTypedef.PropertyInfo.SetValue(newObj, strings);
                        break;
                    case UIFieldType.S32:
                        List<int> ints = [];
                        ReadArray(() => ints.Add(ReadInt32()));
                        propertyTypedef.PropertyInfo.SetValue(newObj, ints);
                        break;
                    case UIFieldType.F32:
                        List<float> floats = [];
                        ReadArray(() => floats.Add(ReadSingle()));
                        propertyTypedef.PropertyInfo.SetValue(newObj, floats);
                        break;
                    case UIFieldType.ObjectRef:
                        List<UIObjectRef> objectRefs = [];
                        ReadArray(() => objectRefs.Add(ReadObjectRef()));
                        propertyTypedef.PropertyInfo.SetValue(newObj, objectRefs);
                        break;

                    case UIFieldType.Object:
                        Type listType = propertyTypedef.PropertyInfo.PropertyType;
                        Type elementType = listType.GetGenericArguments()[0];

                        Type constructedListType = typeof(List<>).MakeGenericType(elementType);
                        IList listInstance = (IList)Activator.CreateInstance(constructedListType);

                        var readerFunc = GetReadObjectDelegate(elementType);

                        ReadArray(() =>
                        {
                            listInstance.Add(readerFunc());
                        });

                        propertyTypedef.PropertyInfo.SetValue(newObj, listInstance);
                        break;

                    default:
                        throw new NotSupportedException($"Array type {propertyTypedef.Type} not supported!");
                }
            }
            else
            {
                ReadElem(newObj, propertyTypedef, compName);
            }
        }

        return newObj;
    }

    private List<ComponentThing> ReadComponentList<T>() where T : new()
    {
        List<ComponentThing> components = [];
        ReadArray(() =>
        {
            long baseOffset = Position;

            int tableOffset = ReadInt32();
            Position += tableOffset - sizeof(int);

            uint numProperties = ReadUInt32();
            uint[] propertiesHashes = ReadUInt32s((int)numProperties);

            Position = baseOffset + 4;
            int[] propertiesOffsets = ReadInt32s((int)numProperties);

            int componentNameOffset = propertiesOffsets[propertiesHashes.IndexOf(XXHash32Custom.Hash("ComponentName"))];
            Position = baseOffset + componentNameOffset;
            string componentName = ReadBulkString();

            int componentOffset = propertiesOffsets[propertiesHashes.IndexOf(XXHash32Custom.Hash("Component"))];
            Position = baseOffset + componentOffset;

            UIComponentReflectedType? subComponentType = UIComponentSerializationCache.GetOrRegisterType(componentName);
            if (subComponentType is null)
                throw new KeyNotFoundException($"Unmapped/Unsupported component type '{componentName}'. " +
                        $"This is not a bug - this file contains UI components that are not yet supported.");

            Component propObj = (Component)GetReadObjectDelegate(subComponentType.Type)();
            components.Add(new ComponentThing() { ComponentName = componentName, Component = propObj });
        });

        return components;
    }

    private void ReadArray(Action callback)
    {
        long baseOfs = Position;
        uint arrayLength = ReadUInt32();
        int[] objectsOffsets = ReadInt32s((int)arrayLength);

        for (int i = 0; i < objectsOffsets.Length; i++)
        {
            Position = baseOfs + objectsOffsets[i];
            callback();
        }
    }

    private void ReadElem<T>(T newObj, UIPropertyTypeDef propertyTypedef, string compName) where T : new()
    {
        switch (propertyTypedef.Type)
        {
            case UIFieldType.S8:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadSByte());
                break;
            case UIFieldType.S16:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadInt16());
                break;
            case UIFieldType.S32:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadInt32());
                break;
            case UIFieldType.U32:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadUInt32());
                break;
            case UIFieldType.Object:
                {
                    _parentName = compName;

                    object propObj = GetReadObjectDelegate(propertyTypedef.PropertyInfo.PropertyType)();
                    propertyTypedef.PropertyInfo.SetValue(newObj, propObj);
                }
                break;
            case UIFieldType.CVec2:
                propertyTypedef.PropertyInfo.SetValue(newObj, new Vector2(ReadSingle(), ReadSingle()));
                break;
            case UIFieldType.CVec3:
                propertyTypedef.PropertyInfo.SetValue(newObj, new Vector3(ReadSingle(), ReadSingle(), ReadSingle()));
                break;
            case UIFieldType.CVec4:
                propertyTypedef.PropertyInfo.SetValue(newObj, new Vector4(ReadSingle(), ReadSingle(), ReadSingle(), ReadSingle()));
                break;
            case UIFieldType.String:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadBulkString());
                break;
            case UIFieldType.F32:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadSingle());
                break;
            case UIFieldType.Bool:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadBoolean());
                break;
            case UIFieldType.CyanStringHash:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadHash());
                break;
            case UIFieldType.ObjectRef:
                propertyTypedef.PropertyInfo.SetValue(newObj, ReadObjectRef());
                break;
            default:
                throw new NotSupportedException("Not supported type");
        }
    }

    private UIObjectRef ReadObjectRef()
    {
        var @ref = new UIObjectRef();
        @ref.ComponentName = ReadHash();
        @ref.Index = ReadInt16();
        @ref.ObjectRefId = ReadInt16();
        return @ref;
    }

    public string ReadBulkString()
    {
        int strByteLength = this.ReadInt32();
        byte[] bytes = new byte[strByteLength];
        this.ReadExactly(bytes);

        string str = Encoding.UTF8.GetString(bytes);
        UIComponentSerializationCache.KnownHashNames.TryAdd(XXHash32Custom.Hash(str), str);
        return str;
    }

    private CyanStringHash ReadHash()
    {
        uint value = ReadUInt32();
        if (UIComponentSerializationCache.KnownHashNames.TryGetValue(value, out string name))
            return new CyanStringHash(name);
        else if (SpriteNameStore.HashToSpriteName.TryGetValue(value, out name))
            return new CyanStringHash(name);
        else
            return new CyanStringHash(value);
    }

    private readonly Dictionary<Type, Func<object>> _readObjectCache = new();
    private MethodInfo _readObjectMethod = (typeof(BulkReader)).GetMethod(nameof(ReadObject));

    private Func<object> GetReadObjectDelegate(Type type)
    {
        if (!_readObjectCache.TryGetValue(type, out var func))
        {
            var method = _readObjectMethod.MakeGenericMethod(type);

            var instance = Expression.Constant(this);
            var call = Expression.Call(instance, method);
            var cast = Expression.Convert(call, typeof(object));

            func = Expression.Lambda<Func<object>>(cast).Compile();
            _readObjectCache[type] = func;
        }

        return func;
    }
}
