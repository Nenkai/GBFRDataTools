using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemConditionGroup
public class ItemConditionGroup // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Animator", UIFieldType.ObjectRef),
         new("Time", UIFieldType.ObjectRef),
         new("Normal", UIFieldType.ObjectRef),
         new("Count", UIFieldType.ObjectRef),
         new("CheckBox", UIFieldType.ObjectRef),
         new("Gauge", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
