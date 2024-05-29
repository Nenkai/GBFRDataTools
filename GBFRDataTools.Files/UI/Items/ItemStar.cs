using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemStar
public class ItemStar // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Stars", FieldType.ObjectRefVector),
         new("StarAnimations", FieldType.ObjectRefVector),
         new("AnimationType", FieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
