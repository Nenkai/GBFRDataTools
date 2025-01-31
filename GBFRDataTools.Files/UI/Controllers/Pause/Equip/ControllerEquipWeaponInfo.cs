using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Equip;

// ui::component::ControllerEquipWeaponInfo
public class ControllerEquipWeaponInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Weapon", UIFieldType.ObjectRef),
        new("Soldout", UIFieldType.ObjectRef),
        new("SoldoutCanvas", UIFieldType.ObjectRef),
        new("AwakeWeaponInfo", UIFieldType.ObjectRef),
        new("ArrowAnims", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
