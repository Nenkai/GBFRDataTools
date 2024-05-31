using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemGemMixSelect
public class ItemGemMixSelect // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Animator", FieldType.ObjectRef),
        new("Button", FieldType.ObjectRef),
        new("Gem", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
