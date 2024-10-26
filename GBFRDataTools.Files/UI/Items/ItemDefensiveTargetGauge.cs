using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemDefensiveTargetGauge
public class ItemDefensiveTargetGauge // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Icon", UIFieldType.ObjectRef),
         new("HpStatusMask", UIFieldType.ObjectRef),
         new("HpGaugeMask", UIFieldType.ObjectRef),
         new("Animator", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
