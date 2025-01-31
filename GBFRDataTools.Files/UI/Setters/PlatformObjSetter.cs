using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::PlatformObjSetter
public class PlatformObjSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Ps5", UIFieldType.Bool),
        new("Ps4", UIFieldType.Bool),
        new("Win32", UIFieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
