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
         new("Color", FieldType.CVec4),
         new("Sprite", FieldType.Object,
         [
             // ui::SpriteRef
             new("TexturePath", FieldType.String),
             new("SpriteName", FieldType.CyanStringHash),
         ]),

         new("MaterialPath", FieldType.String),
         new("Type", FieldType.S32),
         new("FillCenter", FieldType.Bool),
         new("FillMethod", FieldType.S32),
         new("FillOrigin", FieldType.S32),
         new("FillAmount", FieldType.F32),
         new("UvRect", FieldType.CVec4),
         new("RawImage", FieldType.Bool),
         new("Clockwise", FieldType.Bool),
         new("PreserveAspect", FieldType.Bool),
         new(0xE3ED5266, FieldType.S8),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
