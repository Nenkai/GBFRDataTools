using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Image
public class Image // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Color", UIFieldType.CVec4),
         new("Sprite", UIFieldType.Object,
         [
             // ui::SpriteRef
             new("TexturePath", UIFieldType.String),
             new("SpriteName", UIFieldType.CyanStringHash),
         ]),

         new("Type", UIFieldType.S32),
         new("MaterialPath", UIFieldType.String),
         new("FillCenter", UIFieldType.Bool),
         new("FillMethod", UIFieldType.S32),
         new("FillOrigin", UIFieldType.S32),
         new("FillAmount", UIFieldType.F32),
         new("UvRect", UIFieldType.CVec4),
         new("RawImage", UIFieldType.Bool),
         new("Clockwise", UIFieldType.Bool),
         new("PreserveAspect", UIFieldType.Bool),
         new(0xE3ED5266, UIFieldType.S8),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
