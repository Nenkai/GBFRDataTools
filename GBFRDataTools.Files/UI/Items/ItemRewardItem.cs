using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardItem
public class ItemRewardItem // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Anim", UIFieldType.ObjectRef),
        new("MaterialInfo", UIFieldType.ObjectRef),
        new("WeaponInfo", UIFieldType.ObjectRef),
        new("GemInfo", UIFieldType.ObjectRef),
        new("RupiInfo", UIFieldType.ObjectRef),
        new("PendulumInfo", UIFieldType.ObjectRef),
        new("NeedMaterialInfo", UIFieldType.ObjectRef),
        new("ItemIconSetter", UIFieldType.ObjectRef),
        new("ItemNumText01", UIFieldType.ObjectRef),
        new("ItemNumText02", UIFieldType.ObjectRef),
        new("ParentTreasureItem", UIFieldType.ObjectRef),
        new("IconEffect", UIFieldType.ObjectRef),
        new("NewItemAnim", UIFieldType.ObjectRef),
        new("ItemCount", UIFieldType.ObjectRef),
        new("FavoriteObjList", UIFieldType.ObjectRefVector),
        new("PartsBreakObjList", UIFieldType.ObjectRefVector),
        new("NewItemObjList", UIFieldType.ObjectRefVector),
        new("PrevSkillLotObjList", UIFieldType.ObjectRefVector),
        new("PostSkillLotObjList", UIFieldType.ObjectRefVector),
        new("PostSkillLotLevelObjList", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
