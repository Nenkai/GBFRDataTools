using GBFRDataTools.Core.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Menu;

// ui::component::Menu
public class Menu // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new UIPropertyTypeDef("Operation", FieldType.S32),
        new UIPropertyTypeDef("Output", FieldType.S32),
        new UIPropertyTypeDef("ItemMax", FieldType.S32),
        new UIPropertyTypeDef("ViewCount", FieldType.S32),
        new UIPropertyTypeDef("Repeat", FieldType.Bool),
        new UIPropertyTypeDef("Band", FieldType.S32),
        new UIPropertyTypeDef("Margin", FieldType.S32),
        new UIPropertyTypeDef("Objs", FieldType.ObjectArray,
        [
            // ui::component::MenuObj
            new UIPropertyTypeDef("Obj", FieldType.ObjectRef),
            new UIPropertyTypeDef("Event", FieldType.CyanStringHash),
        ]),

        new UIPropertyTypeDef("ScrollBar", FieldType.ObjectRef),
        new UIPropertyTypeDef("Centering", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
