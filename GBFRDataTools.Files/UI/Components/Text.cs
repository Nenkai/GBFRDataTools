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
        new UIPropertyTypeDef("Text", FieldType.String),
        new UIPropertyTypeDef("FontPath", FieldType.String),
        new UIPropertyTypeDef("MaterialPath", FieldType.String),
        new UIPropertyTypeDef("FontSize", FieldType.F32),
        new UIPropertyTypeDef("Color", FieldType.CVec4),
        new UIPropertyTypeDef("IsGradient", FieldType.Bool),
        new UIPropertyTypeDef("ColorMode", FieldType.S8),
        new UIPropertyTypeDef("ColorTL", FieldType.CVec4),
        new UIPropertyTypeDef("ColorTR", FieldType.CVec4),
        new UIPropertyTypeDef("ColorBL", FieldType.CVec4),
        new UIPropertyTypeDef("ColorBR", FieldType.CVec4),
        new UIPropertyTypeDef("Margin", FieldType.CVec4),
        new UIPropertyTypeDef("CharacterSpacing", FieldType.F32),
        new UIPropertyTypeDef("LineSpacing", FieldType.F32),
        new UIPropertyTypeDef("Alignment", FieldType.S16),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
