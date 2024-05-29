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
        new("ItemAnimator", FieldType.ObjectRef),
        new("WindowObj", FieldType.ObjectRef),
        new("CursorObj", FieldType.ObjectRef),
        new("VoiceIcons", FieldType.ObjectRefVector),
        new("Chara", FieldType.ObjectRef),
        new("Texts", FieldType.ObjectRefVector),
        new("Button", FieldType.ObjectRef),
        new("BaseOther", FieldType.ObjectRef),
        new("BasePlayer", FieldType.ObjectRef),
        new("TextObj", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
