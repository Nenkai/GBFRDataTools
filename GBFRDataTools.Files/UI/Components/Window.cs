using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Window
public class Window // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new("Button", UIFieldType.ObjectRef),
         new("SoundContainer", UIFieldType.ObjectRef),
         new("Animator", UIFieldType.ObjectRef),
         new("AssistIcon", UIFieldType.ObjectRef),
         new("ChildButton", UIFieldType.ObjectRef),
         new("OptionLRCursors", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
