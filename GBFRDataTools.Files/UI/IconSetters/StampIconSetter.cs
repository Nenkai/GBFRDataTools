﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.IconSetters;

// ui::component::StampIconSetter
public class StampIconSetter // IconSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Type", UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Properties);
        list.AddRange(IconSetter.GetAllProperties());
        return list;
    }
}
