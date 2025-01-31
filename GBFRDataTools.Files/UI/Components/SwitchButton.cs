using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SwitchButton
public class SwitchButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Button", UIFieldType.ObjectRef),
        new("Lb", UIFieldType.ObjectRef),
        new("Rb", UIFieldType.ObjectRef),
        new("Cancel", UIFieldType.ObjectRef),
        new("Fix", UIFieldType.ObjectRef),
        new("SoundContainer", UIFieldType.ObjectRef),
        new("Animator", UIFieldType.ObjectRef),
        new("ChildButton", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
