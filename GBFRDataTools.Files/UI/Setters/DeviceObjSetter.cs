using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::DeviceObjSetter
public class DeviceObjSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0xD9CEDCB7, UIFieldType.ObjectRefVector),
        new("Keyboard", UIFieldType.ObjectRefVector),
        new(0xA918805D, UIFieldType.ObjectRefVector),
        new(0xBA2624B1, UIFieldType.ObjectRefVector),
        new(0x234E5424, UIFieldType.S32Vector),
    };


    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
