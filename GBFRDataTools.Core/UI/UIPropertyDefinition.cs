using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI;

public class UIPropertyTypeDef
{
    public string Name { get; set; }
    public uint Hash { get; set; }
    public FieldType Type { get; set; }

    public Dictionary<uint, UIPropertyTypeDef> ChildProperties { get; set; } = [];

    public UIPropertyTypeDef(string str, FieldType type, Dictionary<uint, UIPropertyTypeDef> childProperties = null)
    {
        Name = str;
        Hash = XXHash32Custom.Hash(str);
        Type = type;
        ChildProperties = childProperties;
    }

    public UIPropertyTypeDef(uint hash, FieldType type, Dictionary<uint, UIPropertyTypeDef> childProperties = null)
    {
        Name = $"_{hash:X8}";
        Hash = hash;
        Type = type;
        ChildProperties = childProperties;
    }

    public override string ToString()
    {
        return $"{Name} ({Type})";
    }
}

public enum FieldType
{
    Byte,
    UShort,
    Object,
    ObjectArray,
    StringArray,
    Vector2,
    Vector3,
    Vector4,
    String,
    Float,
    Bool,
    UInt,
    IntArray,
    HashAndId,
    HashAndIdArray
}

