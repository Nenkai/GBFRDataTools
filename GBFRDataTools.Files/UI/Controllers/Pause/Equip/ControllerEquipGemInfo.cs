using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Equip;

// ui::component::ControllerEquipGemInfo
public class ControllerEquipGemInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Gem", UIFieldType.ObjectRef),
        new("Soldout", UIFieldType.ObjectRef),
        new("SoldoutCanvas", UIFieldType.ObjectRef),
        new("CharaRoot", UIFieldType.ObjectRef),
        new("AnimationEvent", UIFieldType.ObjectRef),
        new("Charas", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
