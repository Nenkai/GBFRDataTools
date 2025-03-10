﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Entrance;

// ui::component::ControllerBlacksmithTop
public class ControllerBlacksmithTop // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", UIFieldType.ObjectRef),
        new("MenuSub", UIFieldType.ObjectRef),
        new("Bg", UIFieldType.ObjectRef),
        new("SetupEntrance", UIFieldType.ObjectRef),
        new("TradeDetail", UIFieldType.ObjectRef),
        new("Favorite", UIFieldType.ObjectRef),
        new("FavoriteList", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
