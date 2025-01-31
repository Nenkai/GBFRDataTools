using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemSettingDetail
public class ItemSettingDetail // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Cursors", UIFieldType.ObjectRefVector), // 0x3B617342
        new("Titles", UIFieldType.ObjectRefVector),
        new(0x2110046C, UIFieldType.ObjectRefVector),
        new("Buttons", UIFieldType.ObjectRefVector), // 0x91D560D5

        new("Title", UIFieldType.ObjectRef),
        new("Switch", UIFieldType.ObjectRef),
        new("Slider", UIFieldType.ObjectRef),
        new(0x254740BC, UIFieldType.ObjectRef),
        new("InputTextButton", UIFieldType.ObjectRef), // CF38DC02
        new("Window", UIFieldType.ObjectRef), // E09054FC
        new("QuestRankButton", UIFieldType.ObjectRef), // CBC21DED
        new("LobbyTargetButton", UIFieldType.ObjectRef), // 7007CF37
        new("InputKeyButton", UIFieldType.ObjectRef), // A20F174F
        new("CharaIcon", UIFieldType.ObjectRef), // CharaIcon
        new("Line", UIFieldType.ObjectRef), // 1FD95775
        new("Animator", UIFieldType.ObjectRef), // 34D0C15E
        new(0xAD719777, UIFieldType.ObjectRef),
        new(0x4C92D673, UIFieldType.ObjectRef),
        new("FilterIconObj", UIFieldType.ObjectRef),
        new(0x90B326F, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
