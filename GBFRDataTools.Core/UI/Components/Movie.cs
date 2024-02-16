using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::Movie
public class Movie // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Image", FieldType.ObjectRef),
         new UIPropertyTypeDef("FileName", FieldType.String),
         new UIPropertyTypeDef("FadeImage", FieldType.ObjectRef),
         new UIPropertyTypeDef("Loop", FieldType.Bool),
         new UIPropertyTypeDef("FadeTime", FieldType.F32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
