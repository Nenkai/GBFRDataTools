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
        new("ButtonObj", FieldType.ObjectRef),
        new("Animator", FieldType.ObjectRef),
        new("Icon", FieldType.ObjectRef),
        new("CursorSelect", FieldType.ObjectRef),
        new("CursorFixed", FieldType.ObjectRef),
        new("Texts", FieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
