using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::TextAutoLineFeed
public class TextAutoLineFeed // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Type", UIFieldType.S32),
        new("Width", UIFieldType.S8),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
