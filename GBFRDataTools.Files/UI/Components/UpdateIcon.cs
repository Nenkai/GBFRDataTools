using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::UpdateIcon
public class UpdateIcon // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Animator", UIFieldType.ObjectRef),
         new("Icon", UIFieldType.ObjectRef),
         new("ImageSetter", UIFieldType.ObjectRef),
         new("Size", UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
