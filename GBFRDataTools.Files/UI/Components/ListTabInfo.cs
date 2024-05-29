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
        new("Button", FieldType.ObjectRefVector),
        new("ButtonImage", FieldType.ObjectRefVector),
        new("SingleDisables", FieldType.ObjectRefVector),
        new("UpdateIcons", FieldType.ObjectRefVector),
        new("TabAnim", FieldType.ObjectRef),
        new("TabTitle", FieldType.ObjectRef),
        new("LeftText", FieldType.ObjectRef),
        new("RightText", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
