using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::TextRuby
public class TextRuby // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("Font", UIFieldType.String),
         new UIPropertyTypeDef("Material", UIFieldType.String),
         new UIPropertyTypeDef("FontSize", UIFieldType.S32),
         new UIPropertyTypeDef("Spacing", UIFieldType.S32),
         new UIPropertyTypeDef("Color", UIFieldType.CVec4),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
