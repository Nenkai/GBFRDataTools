using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::ShopSellInfo
public class ShopSellInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Mode", UIFieldType.S32),
         new("Sets", UIFieldType.ObjectRefVector),
         new("MaterialSets", UIFieldType.ObjectRefVector),
         new("GemSets", UIFieldType.ObjectRefVector),
         new("PendulumSets", UIFieldType.ObjectRefVector),
         new("Empties", UIFieldType.ObjectRefVector),
         new("ListTexts", UIFieldType.ObjectRefVector),
         new("PriceTexts", UIFieldType.ObjectRefVector),
         new("ItemTexts", UIFieldType.ObjectRefVector),
         new("NeedCountTexts", UIFieldType.ObjectRefVector),
         new("SellCountTexts", UIFieldType.ObjectRefVector),
         new("PositionCountTexts", UIFieldType.ObjectRefVector),
         new("LvTexts", UIFieldType.ObjectRefVector),
         new("ItemIcons", UIFieldType.ObjectRefVector),
         new("GemIcons", UIFieldType.ObjectRefVector),
         new("SkillIcons", UIFieldType.ObjectRefVector),
         new("ItemImageSets", UIFieldType.ObjectRefVector),
         new("MenuDial", UIFieldType.ObjectRef),
         new("CheckButton", UIFieldType.ObjectRef),
         new("Icon", UIFieldType.ObjectRef),
         new("UpdateIcon", UIFieldType.ObjectRef),
         new("UpdateCharaIcon", UIFieldType.ObjectRef),
         new("SkillHorizontalLayoutGroup", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
