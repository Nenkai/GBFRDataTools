using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::KeyboardBtnSetter
public class KeyboardBtnSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x309AA8D5, FieldType.ObjectRefVector),
        new(0xE147AAAC, FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
