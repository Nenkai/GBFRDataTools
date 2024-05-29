using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemLevel
public class ItemLevel // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Level", FieldType.ObjectRef),
         new("LevelMaxNum", FieldType.ObjectRef),
         new("LevelMaxNumObj", FieldType.ObjectRef),
         new("LevelMax", FieldType.ObjectRef),
         new("ExpObj", FieldType.ObjectRef),
         new("Exp", FieldType.ObjectRef),
         new("Gauge", FieldType.ObjectRef),
         new("GaugeImg", FieldType.ObjectRef),
         new("HideExp", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
