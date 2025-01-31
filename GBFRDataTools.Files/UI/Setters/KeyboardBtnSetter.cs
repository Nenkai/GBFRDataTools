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
        new("ObjList", UIFieldType.ObjectRefVector),
        new(0xE147AAAC, UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
