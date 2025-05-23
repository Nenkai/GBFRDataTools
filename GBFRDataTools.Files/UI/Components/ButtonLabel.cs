﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonLabel
public class ButtonLabel // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Cursor", UIFieldType.ObjectRef),
        new("Button", UIFieldType.ObjectRef),
        new("Text", UIFieldType.ObjectRef),
        new("ImageButton", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
