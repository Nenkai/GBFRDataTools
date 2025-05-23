﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI;

public class UIPropertyTypeDef
{
    public string Name { get; set; }
    public uint Hash { get; set; }
    public UIFieldType Type { get; set; }

    public List<UIPropertyTypeDef> ChildProperties { get; set; } = [];

    public static Dictionary<uint, string> HashToPropName = [];

    public UIPropertyTypeDef(string str, UIFieldType type, List<UIPropertyTypeDef> childProperties = null)
    {
        Name = str;
        Hash = XXHash32Custom.Hash(str);

        HashToPropName.TryAdd(Hash, str);

        Type = type;
        ChildProperties = childProperties;
    }

    public UIPropertyTypeDef(uint hash, UIFieldType type, List<UIPropertyTypeDef> childProperties = null)
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

public enum UIFieldType
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
    U32,
    CyanStringHash,
    CyanStringHashVector,
    S32Vector,
    F32Vector,
    ObjectRef,
    ObjectRefVector
}