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
        new("Text", UIFieldType.String),
        new("FontPath", UIFieldType.String),
        new("MaterialPath", UIFieldType.String),
        new("FontSize", UIFieldType.F32),
        new("Color", UIFieldType.CVec4),
        new("Margin", UIFieldType.CVec4),
        new("IsGradient", UIFieldType.Bool),
        new("ColorMode", UIFieldType.S8),
        new("ColorTL", UIFieldType.CVec4),
        new("ColorTR", UIFieldType.CVec4),
        new("ColorBL", UIFieldType.CVec4),
        new("ColorBR", UIFieldType.CVec4),
        new("CharacterSpacing", UIFieldType.F32),
        new("LineSpacing", UIFieldType.F32),
        new("Alignment", UIFieldType.S16),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
