using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemWinCutLog
public class ItemWinCutLog // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("ItemAnimator", UIFieldType.ObjectRef),
        new("WindowObj", UIFieldType.ObjectRef),
        new("CursorObj", UIFieldType.ObjectRef),
        new("VoiceIcons", UIFieldType.ObjectRefVector),
        new("Chara", UIFieldType.ObjectRef),
        new("Texts", UIFieldType.ObjectRefVector),
        new("Button", UIFieldType.ObjectRef),
        new("BaseOther", UIFieldType.ObjectRef),
        new("BasePlayer", UIFieldType.ObjectRef),
        new("TextObj", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
