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
         new("DissolveTexture", UIFieldType.Object,
         [
             // ui::SpriteRef
             new("TexturePath", UIFieldType.String),
             new("SpriteName", UIFieldType.CyanStringHash),
         ]),
         new("Cutoff", UIFieldType.F32),
         new("AddColor1Enabled", UIFieldType.Bool),
         new("AddColor1", UIFieldType.CVec4),
         new("BorderWidth1", UIFieldType.F32),
         new("AddColor2Enabled", UIFieldType.Bool),
         new("AddColor2", UIFieldType.CVec4),
         new("BorderWidth2", UIFieldType.F32),
         new("TrailEnabled", UIFieldType.Bool),
         new("TrailWidth", UIFieldType.F32),
         new("RenderType", UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
