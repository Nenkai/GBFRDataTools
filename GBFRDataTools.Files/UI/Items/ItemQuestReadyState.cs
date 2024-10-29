using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestReadyState
public class ItemQuestReadyState // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new(0x5E27D316, UIFieldType.ObjectRef),
         new(0x91A42AF1, UIFieldType.ObjectRef),
         new(0xAB48D024, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
