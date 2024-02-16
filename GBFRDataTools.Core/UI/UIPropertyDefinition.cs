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

    public List<UIPropertyTypeDef> ChildProperties { get; set; } = [];

    public UIPropertyTypeDef(string str, FieldType type, List<UIPropertyTypeDef> childProperties = null)
    {
        Name = str;
        Hash = XXHash32Custom.Hash(str);
        Type = type;
        ChildProperties = childProperties;
    }

    public UIPropertyTypeDef(uint hash, FieldType type, List<UIPropertyTypeDef> childProperties = null)
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
    S8,
    S16,
    Object,
    ObjectArray,
    StringVector,
    CVec2,
    CVec3,
    CVec4,
    String,
    F32,
    Bool,
    S32,
    CyanStringHash,
    S32Vector,
    ObjectRef,
    ObjectRefVector
}

