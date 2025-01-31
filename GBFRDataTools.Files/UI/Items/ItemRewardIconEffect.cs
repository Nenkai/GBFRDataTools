using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardIconEffect
public class ItemRewardIconEffect // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("LowObjs", UIFieldType.ObjectRefVector),
         new("MiddleObjs", UIFieldType.ObjectRefVector),
         new("HighObjs", UIFieldType.ObjectRefVector),
         new("VeryHighObjs", UIFieldType.ObjectRefVector),
         new("AuraTextures", UIFieldType.ObjectRefVector),
         new("KiraTextures", UIFieldType.ObjectRefVector),
         new("AuraColors", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
