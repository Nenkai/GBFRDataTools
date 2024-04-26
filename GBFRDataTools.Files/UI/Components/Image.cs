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
         new UIPropertyTypeDef("Color", FieldType.CVec4),
         new UIPropertyTypeDef("Sprite", FieldType.Object, new()
         {
             // ui::SpriteRef
             new UIPropertyTypeDef("TexturePath", FieldType.String),
             new UIPropertyTypeDef("SpriteName", FieldType.CyanStringHash),
         }),

         new UIPropertyTypeDef("MaterialPath", FieldType.String),
         new UIPropertyTypeDef("Type", FieldType.S32),
         new UIPropertyTypeDef("FillCenter", FieldType.Bool),
         new UIPropertyTypeDef("FillMethod", FieldType.S32),
         new UIPropertyTypeDef("FillOrigin", FieldType.S32),
         new UIPropertyTypeDef("FillAmount", FieldType.S32),
         new UIPropertyTypeDef("UvRect", FieldType.CVec4),
         new UIPropertyTypeDef("RawImage", FieldType.Bool),
         new UIPropertyTypeDef("Clockwise", FieldType.Bool),
         new UIPropertyTypeDef("PreserveAspect", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
