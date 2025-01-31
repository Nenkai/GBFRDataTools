using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardInfo
public class ItemRewardInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Item", UIFieldType.ObjectRef),
        new("ButtonGuide", UIFieldType.ObjectRef),
        new("Anim", UIFieldType.ObjectRef),
        new("FavoriteIconObject", UIFieldType.ObjectRef),
        new("NewIconObject", UIFieldType.ObjectRef),
        new("SoundContainer", UIFieldType.ObjectRef),
        new("NumImageBGs", UIFieldType.ObjectRefVector),
        new("NumTextParentObjs", UIFieldType.ObjectRefVector),
        new("NumTexts", UIFieldType.ObjectRefVector),
        new("FavoriteNGTexts", UIFieldType.ObjectRefVector),
        new("BgType", UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
