using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerWinCutWordList
public class ControllerWinCutWordList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Cancel", FieldType.ObjectRef),
        new("ControllerObj", FieldType.ObjectRef),
        new("ControllerAnim", FieldType.ObjectRef),
        new("ListObj", FieldType.ObjectRef),
        new("TabParent", FieldType.ObjectRef),
        new("CategoryText", FieldType.ObjectRef),
        new("CategoryPrevText", FieldType.ObjectRef),
        new("CategoryNextText", FieldType.ObjectRef),
        new("TabButtons", FieldType.ObjectRefVector),
        new(0x66AEB2E3, FieldType.ObjectRef),
        new(0x94A60A77, FieldType.ObjectRef),
        new("Gauss", FieldType.ObjectRef),
        new(0xE39D76BF, FieldType.ObjectRef),
        new(0xF923B194, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
