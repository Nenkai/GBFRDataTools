using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::ItemLevel
public class ItemLevel // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Level", FieldType.ObjectRef),
         new UIPropertyTypeDef("LevelMaxNum", FieldType.ObjectRef),
         new UIPropertyTypeDef("LevelMaxNumObj", FieldType.ObjectRef),
         new UIPropertyTypeDef("LevelMax", FieldType.ObjectRef),
         new UIPropertyTypeDef("ExpObj", FieldType.ObjectRef),
         new UIPropertyTypeDef("Exp", FieldType.ObjectRef),
         new UIPropertyTypeDef("Gauge", FieldType.ObjectRef),
         new UIPropertyTypeDef("GaugeImg", FieldType.ObjectRef),
         new UIPropertyTypeDef("HideExp", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
