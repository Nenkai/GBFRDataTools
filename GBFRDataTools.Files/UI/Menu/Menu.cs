using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::Menu
public class Menu // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Operation", UIFieldType.S32),
        new("Output", UIFieldType.S32),
        new("ItemMax", UIFieldType.S32),
        new("ViewCount", UIFieldType.S32),
        new("Repeat", UIFieldType.Bool),
        new("Band", UIFieldType.S32),
        new("Margin", UIFieldType.S32),
        new("Objs", UIFieldType.ObjectArray,
        [
            // ui::component::MenuObj
            new("Obj", UIFieldType.ObjectRef),
            new("Event", UIFieldType.CyanStringHash),
        ]),

        new("ScrollBar", UIFieldType.ObjectRef),
        new("Centering", UIFieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
