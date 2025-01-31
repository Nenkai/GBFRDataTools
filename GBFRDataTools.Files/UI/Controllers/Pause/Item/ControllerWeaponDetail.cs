using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Item;

// ui::component::ControllerWeaponDetail
public class ControllerWeaponDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Weapon", UIFieldType.ObjectRef),
        new("Chara", UIFieldType.ObjectRef),
        new("CharaName", UIFieldType.ObjectRef),
        new("Visibles", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
