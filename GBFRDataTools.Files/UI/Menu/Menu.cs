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
        new("Operation", FieldType.S32),
        new("Output", FieldType.S32),
        new("ItemMax", FieldType.S32),
        new("ViewCount", FieldType.S32),
        new("Repeat", FieldType.Bool),
        new("Band", FieldType.S32),
        new("Margin", FieldType.S32),
        new("Objs", FieldType.ObjectArray,
        [
            // ui::component::MenuObj
            new("Obj", FieldType.ObjectRef),
            new("Event", FieldType.CyanStringHash),
        ]),

        new("ScrollBar", FieldType.ObjectRef),
        new("Centering", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
