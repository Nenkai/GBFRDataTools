using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ContentSizeFitter
public class ContentSizeFitter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new("HorizontalFit", UIFieldType.S32),
         new("VerticalFit", UIFieldType.S32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
