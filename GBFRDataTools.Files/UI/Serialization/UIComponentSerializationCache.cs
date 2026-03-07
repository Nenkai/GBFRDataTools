using GBFRDataTools.Files.UI.Types;
using GBFRDataTools.Hashing;

using System.Globalization;
using System.Numerics;
using System.Reflection;

namespace GBFRDataTools.Files.UI.Serialization;

public class UIComponentSerializationCache
{
    private static Dictionary<string, UIComponentReflectedType> _typeDefs = [];
    public static Dictionary<uint, string> KnownHashNames { get; private set; } = new() 
    { 
        [XXHash32Custom.Hash(string.Empty)] = string.Empty 
    };

    private static Dictionary<Type, UIFieldType> _typeToUiType = new()
    {
        [typeof(Vector4)] = UIFieldType.CVec4,
        [typeof(Vector3)] = UIFieldType.CVec3,
        [typeof(Vector2)] = UIFieldType.CVec2,
        [typeof(int)] = UIFieldType.S32,
        [typeof(float)] = UIFieldType.F32,
        [typeof(uint)] = UIFieldType.U32,
        [typeof(short)] = UIFieldType.S16,
        [typeof(sbyte)] = UIFieldType.S8,
        [typeof(string)] = UIFieldType.String,
        [typeof(bool)] = UIFieldType.Bool,
        [typeof(UIObjectRef)] = UIFieldType.ObjectRef,
        [typeof(CyanStringHash)] = UIFieldType.CyanStringHash,
    };

    private static Dictionary<string, Type> _allUiTypes = Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(t => t.IsClass && !t.IsAbstract && (t.Namespace.StartsWith("GBFRDataTools.Files.UI.Components") || t.Namespace.StartsWith("GBFRDataTools.Files.UI.Assets")) )
        .ToDictionary(e => e.Name, v => v);

    static UIComponentSerializationCache()
    {
        RegisterAllComponents();
    }

    private static void RegisterAllComponents()
    {
        foreach (var type in _allUiTypes)
            GetOrRegisterType(type.Key);
    }

    public static UIComponentReflectedType? GetOrRegisterType(string typeName)
    {
        if (!_allUiTypes.TryGetValue(typeName, out Type? managedType))
            return null;

        KnownHashNames.TryAdd(XXHash32Custom.Hash(managedType.Name), managedType.Name);

        if (!_typeDefs.TryGetValue(typeName, out UIComponentReflectedType? reflectedType))
        {
            reflectedType = new UIComponentReflectedType() { Type = managedType, Name = typeName };

            foreach (PropertyInfo prop in managedType.GetProperties())
            {
                Type propType = prop.PropertyType;
                KnownHashNames.TryAdd(XXHash32Custom.Hash(prop.Name), prop.Name);

                UIPropertyTypeDef propDef;

                UIFieldType uiPropType;
                bool isArray = false;
                if (prop.PropertyType.IsGenericType)
                {
                    Type listElemType = prop.PropertyType.GenericTypeArguments[0];
                    if (!_typeToUiType.TryGetValue(listElemType, out uiPropType))
                        uiPropType = UIFieldType.Object;

                    isArray = true;
                }
                else
                {
                    if (!_typeToUiType.TryGetValue(propType, out uiPropType))
                        uiPropType = UIFieldType.Object;
                }

                ReadOnlySpan<char> name = prop.Name;
                if (name.EndsWith('_'))
                    name = name.TrimEnd('_');

                if (name.StartsWith("_") && uint.TryParse(name[1..], NumberStyles.HexNumber, CultureInfo.InvariantCulture, out uint hash))
                    propDef = new UIPropertyTypeDef(hash, prop, uiPropType, isArray);
                else
                    propDef = new UIPropertyTypeDef(name.ToString(), prop, uiPropType, isArray);

                reflectedType.Properties.Add(propDef);
            }
        }

        return reflectedType;
    }
}

public class UIComponentReflectedType
{
    public string Name { get; set; }
    public Type Type { get; set; }
    public List<UIPropertyTypeDef> Properties { get; set; } = [];
}
