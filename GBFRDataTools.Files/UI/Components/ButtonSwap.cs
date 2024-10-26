using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonSwap
public class ButtonSwap // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("ButtonGuideType", UIFieldType.String),
         new("ButtonGuide", UIFieldType.ObjectRef),
         new("ButtonGuideShortcut", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
