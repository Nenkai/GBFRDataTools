
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::MaskImageSetter
public class MaskImageSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("ImageDataPath", UIFieldType.String),
        new("Mask", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
