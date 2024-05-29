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
         new("Mode", FieldType.S32),
         new("Sets", FieldType.ObjectRefVector),
         new("MaterialSets", FieldType.ObjectRefVector),
         new("GemSets", FieldType.ObjectRefVector),
         new("PendulumSets", FieldType.ObjectRefVector),
         new("Empties", FieldType.ObjectRefVector),
         new("ListTexts", FieldType.ObjectRefVector),
         new("PriceTexts", FieldType.ObjectRefVector),
         new("ItemTexts", FieldType.ObjectRefVector),
         new("NeedCountTexts", FieldType.ObjectRefVector),
         new("SellCountTexts", FieldType.ObjectRefVector),
         new("PositionCountTexts", FieldType.ObjectRefVector),
         new("LvTexts", FieldType.ObjectRefVector),
         new("ItemIcons", FieldType.ObjectRefVector),
         new("GemIcons", FieldType.ObjectRefVector),
         new("SkillIcons", FieldType.ObjectRefVector),
         new("ItemImageSets", FieldType.ObjectRefVector),
         new("MenuDial", FieldType.ObjectRef),
         new("CheckButton", FieldType.ObjectRef),
         new("Icon", FieldType.ObjectRef),
         new("UpdateIcon", FieldType.ObjectRef),
         new("UpdateCharaIcon", FieldType.ObjectRef),
         new("SkillHorizontalLayoutGroup", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
