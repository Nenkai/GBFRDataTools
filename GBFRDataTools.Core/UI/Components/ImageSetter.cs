using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::ImageSetter
public class ImageSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("ImageDataPath", FieldType.String),
         new UIPropertyTypeDef("Target", FieldType.ObjectRef),

         new UIPropertyTypeDef(0x2DA95AA8, FieldType.CyanStringHash),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
