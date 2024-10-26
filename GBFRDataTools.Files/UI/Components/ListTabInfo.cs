using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ListTabInfo
public class ListTabInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Button", UIFieldType.ObjectRefVector),
        new("ButtonImage", UIFieldType.ObjectRefVector),
        new("SingleDisables", UIFieldType.ObjectRefVector),
        new("UpdateIcons", UIFieldType.ObjectRefVector),
        new("TabAnim", UIFieldType.ObjectRef),
        new("TabTitle", UIFieldType.ObjectRef),
        new("LeftText", UIFieldType.ObjectRef),
        new("RightText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
