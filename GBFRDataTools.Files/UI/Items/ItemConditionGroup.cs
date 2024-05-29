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
         new("Animator", FieldType.ObjectRef),
         new("Time", FieldType.ObjectRef),
         new("Normal", FieldType.ObjectRef),
         new("Count", FieldType.ObjectRef),
         new("CheckBox", FieldType.ObjectRef),
         new("Gauge", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
