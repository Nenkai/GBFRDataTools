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
        new("Title", FieldType.ObjectRef),
        new("Menu", FieldType.ObjectRef),
        new("Bg", FieldType.ObjectRef),
        new("List", FieldType.ObjectRef),
        new("ScrollBase", FieldType.ObjectRef),
        new("ScrollBar", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
