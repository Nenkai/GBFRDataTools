using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Equip;

// ui::component::ControllerEquipInfo02
public class ControllerEquipInfo02 // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Chara", UIFieldType.ObjectRef),
        new("Lines", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
