using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerSettingSubMenu
public class ControllerSettingSubMenu // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Title", UIFieldType.ObjectRef),
        new("Menu", UIFieldType.ObjectRef),
        new("Bg", UIFieldType.ObjectRef),
        new("List", UIFieldType.ObjectRef),
        new("ScrollBase", UIFieldType.ObjectRef),
        new("ScrollBar", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
