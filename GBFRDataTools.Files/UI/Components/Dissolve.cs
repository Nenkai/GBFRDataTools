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
         new UIPropertyTypeDef("DissolveTexture", FieldType.ObjectRef,
         [
             // ui::SpriteRef
             new UIPropertyTypeDef("TexturePath", FieldType.String),
             new UIPropertyTypeDef("SpriteName", FieldType.CyanStringHash),
         ]),
         new UIPropertyTypeDef("Cutoff", FieldType.F32),
         new UIPropertyTypeDef("AddColor1Enabled", FieldType.Bool),
         new UIPropertyTypeDef("AddColor1", FieldType.CVec4),
         new UIPropertyTypeDef("BorderWidth1", FieldType.F32),
         new UIPropertyTypeDef("AddColor2Enabled", FieldType.Bool),
         new UIPropertyTypeDef("AddColor2", FieldType.CVec4),
         new UIPropertyTypeDef("BorderWidth2", FieldType.F32),
         new UIPropertyTypeDef("TrailEnabled", FieldType.Bool),
         new UIPropertyTypeDef("TrailWidth", FieldType.F32),
         new UIPropertyTypeDef("RenderType", FieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
