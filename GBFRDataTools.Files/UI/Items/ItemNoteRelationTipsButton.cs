using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemNoteRelationTipsButton
public class ItemNoteRelationTipsButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Texts", UIFieldType.ObjectRefVector),
         new("Icon", UIFieldType.ObjectRef),
         new("UpdateIcon", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
