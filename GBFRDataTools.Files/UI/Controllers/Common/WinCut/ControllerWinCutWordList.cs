using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.WinCut;

// ui::component::ControllerWinCutWordList
public class ControllerWinCutWordList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Cancel", UIFieldType.ObjectRef),
        new("ControllerObj", UIFieldType.ObjectRef),
        new("ControllerAnim", UIFieldType.ObjectRef),
        new("ListObj", UIFieldType.ObjectRef),
        new("TabParent", UIFieldType.ObjectRef),
        new("CategoryText", UIFieldType.ObjectRef),
        new("CategoryPrevText", UIFieldType.ObjectRef),
        new("CategoryNextText", UIFieldType.ObjectRef),
        new("TabButtons", UIFieldType.ObjectRefVector),
        new(0x66AEB2E3, UIFieldType.ObjectRef),
        new(0x94A60A77, UIFieldType.ObjectRef),
        new("Gauss", UIFieldType.ObjectRef),
        new(0xE39D76BF, UIFieldType.ObjectRef),
        new(0xF923B194, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
