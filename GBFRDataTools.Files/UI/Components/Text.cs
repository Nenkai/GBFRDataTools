using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Text
public class Text // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Text", FieldType.String),
        new("FontPath", FieldType.String),
        new("MaterialPath", FieldType.String),
        new("FontSize", FieldType.F32),
        new("Color", FieldType.CVec4),
        new("IsGradient", FieldType.Bool),
        new("ColorMode", FieldType.S8),
        new("ColorTL", FieldType.CVec4),
        new("ColorTR", FieldType.CVec4),
        new("ColorBL", FieldType.CVec4),
        new("ColorBR", FieldType.CVec4),
        new("Margin", FieldType.CVec4),
        new("CharacterSpacing", FieldType.F32),
        new("LineSpacing", FieldType.F32),
        new("Alignment", FieldType.S16),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
