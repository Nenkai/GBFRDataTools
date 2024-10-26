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
         new("Level", UIFieldType.ObjectRef),
         new("LevelMaxNum", UIFieldType.ObjectRef),
         new("LevelMaxNumObj", UIFieldType.ObjectRef),
         new("LevelMax", UIFieldType.ObjectRef),
         new("ExpObj", UIFieldType.ObjectRef),
         new("Exp", UIFieldType.ObjectRef),
         new("Gauge", UIFieldType.ObjectRef),
         new("GaugeImg", UIFieldType.ObjectRef),
         new("HideExp", UIFieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
