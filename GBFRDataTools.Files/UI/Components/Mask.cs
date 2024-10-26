using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Mask
public class Mask // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Sprite", UIFieldType.Object, new()
         {
             // ui::SpriteRef
             new("TexturePath", UIFieldType.String),
             new("SpriteName", UIFieldType.CyanStringHash),
         }),

         new("Offset", UIFieldType.CVec2),
         new("ChannelWeights", UIFieldType.CVec4),
         new("InvertMask", UIFieldType.Bool),
         new("InvertOutsides", UIFieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
