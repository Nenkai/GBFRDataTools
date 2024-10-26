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
        new("Base03ImageSetters", UIFieldType.ObjectRefVector),
        new("Add01ImageSetters", UIFieldType.ObjectRefVector),
        new("Add02ImageSetters", UIFieldType.ObjectRefVector),
        new("Add03ImageSetters", UIFieldType.ObjectRefVector),
        new("Add04ImageSetters", UIFieldType.ObjectRefVector),
        new("ChangeColorImages", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
