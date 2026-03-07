using GBFRDataTools.Hashing;

using System.Reflection;

namespace GBFRDataTools.Files.UI;

public class UIPropertyTypeDef
{
    public string Name { get; set; }
    public uint Hash { get; set; }
    public UIFieldType Type { get; set; }
    public PropertyInfo PropertyInfo { get; set; }
    public bool IsArray { get; set; }

    public UIPropertyTypeDef(string str, PropertyInfo propertyInfo, UIFieldType type, bool isArray = false)
    {
        Name = str;
        Hash = XXHash32Custom.Hash(str);
        Type = type;
        IsArray = isArray;
        PropertyInfo = propertyInfo;
    }

    public UIPropertyTypeDef(uint hash, PropertyInfo propertyInfo, UIFieldType type, bool isArray = false)
    {
        Name = $"_{hash:X8}";
        Hash = hash;
        Type = type;
        IsArray = isArray;
        PropertyInfo = propertyInfo;
    }

    public override string ToString()
    {
        return $"{Name} ({Type})";
    }
}

public enum UIFieldType
{
    Unknown,
    S8,
    S16,
    Object,
    CVec2,
    CVec3,
    CVec4,
    String,
    F32,
    Bool,
    S32,
    U32,
    CyanStringHash,
    ObjectRef,
}