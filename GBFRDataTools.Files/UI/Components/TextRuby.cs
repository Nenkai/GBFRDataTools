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
         new UIPropertyTypeDef("Font", FieldType.String),
         new UIPropertyTypeDef("Material", FieldType.String),
         new UIPropertyTypeDef("FontSize", FieldType.S32),
         new UIPropertyTypeDef("Spacing", FieldType.S32),
         new UIPropertyTypeDef("Color", FieldType.CVec4),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
