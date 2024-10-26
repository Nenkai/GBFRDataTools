using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemWinCutWordlist
public class ItemWinCutWordlist // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("ButtonObj", UIFieldType.ObjectRef),
        new("Animator", UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("CursorSelect", UIFieldType.ObjectRef),
        new("CursorFixed", UIFieldType.ObjectRef),
        new("Texts", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
