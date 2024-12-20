﻿using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Entrance;

// ui::component::ControllerQuestCounterMenu
public class ControllerQuestCounterMenu // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new("SetupEntrance", UIFieldType.ObjectRef),
         new("FavoriteList", UIFieldType.ObjectRef),
         new("MenuQuestCounter", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
