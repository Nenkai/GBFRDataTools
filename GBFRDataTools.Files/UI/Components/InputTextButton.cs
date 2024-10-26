using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::InputTextButton
public class InputTextButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Button", UIFieldType.ObjectRef),
        new("ItemName", UIFieldType.ObjectRef),
        new("SoundContainer", UIFieldType.ObjectRef),
        new(0x2AA63E10, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
