using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerBlacksmithResult
public class ControllerBlacksmithWeaponList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("WeaponList", FieldType.ObjectRef),
        new("Empty", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("ScrollArrowUp", FieldType.ObjectRef),
        new("ScrollArrowDown", FieldType.ObjectRef),
        new("MenuItemAnimators", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
