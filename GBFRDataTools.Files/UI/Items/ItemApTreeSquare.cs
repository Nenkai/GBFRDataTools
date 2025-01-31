using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemApTreeSquare
public class ItemApTreeSquare // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("ApInfo", UIFieldType.ObjectRef),
        new("Animator", UIFieldType.ObjectRef),
        new("Button", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
