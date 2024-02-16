using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::Mask
public class Mask // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Sprite", FieldType.Object, new()
         {
             // ui::SpriteRef
             new UIPropertyTypeDef("TexturePath", FieldType.String),
             new UIPropertyTypeDef("SpriteName", FieldType.CyanStringHash),
         }),

         new UIPropertyTypeDef("Offset", FieldType.CVec2),
         new UIPropertyTypeDef("ChannelWeights", FieldType.CVec4),
         new UIPropertyTypeDef("InvertMask", FieldType.Bool),
         new UIPropertyTypeDef("InvertOutsides", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
