using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Shop.Mix;

// ui::component::ControllerGemMixResult
public class ControllerGemMixResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Levels", UIFieldType.ObjectRefVector),
        new("Telops", UIFieldType.ObjectRefVector),
        new(0xCF45CD3D, UIFieldType.ObjectRefVector),
        new(0x929AC963, UIFieldType.ObjectRefVector),
        new("Gem", UIFieldType.ObjectRef), // 58D9CC66
        new("Menu", UIFieldType.ObjectRef), // 19F9A07D
        new("New", UIFieldType.ObjectRef), // DB35BD47
        new("SkillAnimator", UIFieldType.ObjectRef),
        new("FixShortcut", UIFieldType.ObjectRef), // 887CD4C6
        new(0x6570B05D, UIFieldType.ObjectRef),
        new("ChangeSkillDispMode", UIFieldType.ObjectRef), // CE59164A
        new("Mode", UIFieldType.S32), // A888CFB0
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
