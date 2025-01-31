using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemShopGachaTotalResult
public class ItemShopGachaTotalResult // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("GemInfo", UIFieldType.ObjectRef),
        new("PendulumInfo", UIFieldType.ObjectRef),
        new("Effect", UIFieldType.ObjectRef),
        new("NewIcon", UIFieldType.ObjectRef),
        new(0x7D183F2A, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
