using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Dissolve
public class Dissolve // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("DissolveTexture", FieldType.Object,
         [
             // ui::SpriteRef
             new("TexturePath", FieldType.String),
             new("SpriteName", FieldType.CyanStringHash),
         ]),
         new("Cutoff", FieldType.F32),
         new("AddColor1Enabled", FieldType.Bool),
         new("AddColor1", FieldType.CVec4),
         new("BorderWidth1", FieldType.F32),
         new("AddColor2Enabled", FieldType.Bool),
         new("AddColor2", FieldType.CVec4),
         new("BorderWidth2", FieldType.F32),
         new("TrailEnabled", FieldType.Bool),
         new("TrailWidth", FieldType.F32),
         new("RenderType", FieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
