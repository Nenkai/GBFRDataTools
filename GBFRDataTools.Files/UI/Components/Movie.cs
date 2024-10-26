using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Movie
public class Movie // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Image", UIFieldType.ObjectRef),
         new UIPropertyTypeDef("FileName", UIFieldType.String),
         new UIPropertyTypeDef("FadeImage", UIFieldType.ObjectRef),
         new UIPropertyTypeDef("Loop", UIFieldType.Bool),
         new UIPropertyTypeDef("FadeTime", UIFieldType.F32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
