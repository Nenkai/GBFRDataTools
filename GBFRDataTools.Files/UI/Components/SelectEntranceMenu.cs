using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SelectEntranceMenu
public class SelectEntranceMenu // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Base03ImageSetters", FieldType.ObjectRefVector),
        new("Add01ImageSetters", FieldType.ObjectRefVector),
        new("Add02ImageSetters", FieldType.ObjectRefVector),
        new("Add03ImageSetters", FieldType.ObjectRefVector),
        new("Add04ImageSetters", FieldType.ObjectRefVector),
        new("ChangeColorImages", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
