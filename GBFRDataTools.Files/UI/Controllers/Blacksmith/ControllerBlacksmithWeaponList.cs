using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Blacksmith;

// ui::component::ControllerBlacksmithResult
public class ControllerBlacksmithWeaponList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("WeaponList", UIFieldType.ObjectRef),
        new("Empty", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("ScrollArrowUp", UIFieldType.ObjectRef),
        new("ScrollArrowDown", UIFieldType.ObjectRef),
        new("MenuItemAnimators", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
