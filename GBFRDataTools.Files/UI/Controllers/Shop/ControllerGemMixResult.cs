using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Shop;

// ui::component::ControllerGemMixResult
public class ControllerGemMixResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", UIFieldType.ObjectRef),
        new("Gem", UIFieldType.ObjectRef),
        new(0x6570B05D, UIFieldType.ObjectRef),
        new("FixShortcut", UIFieldType.ObjectRef),
        new(0x929AC963, UIFieldType.ObjectRefVector),
        new("Mode", UIFieldType.S32),
        new("ChangeSkillDispMode", UIFieldType.ObjectRef),
        new("New", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
