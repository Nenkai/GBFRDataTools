using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Shop.Gene;

// ui::component::ControllerShopGachaDetail
public class ControllerShopGachaDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Info", UIFieldType.ObjectRef),
        new("Prev", UIFieldType.ObjectRef),
        new("Next", UIFieldType.ObjectRef),
        new("Page", UIFieldType.ObjectRef),
        new("PageMax", UIFieldType.ObjectRef),
        new("Gem", UIFieldType.ObjectRef),
        new("Pendulum", UIFieldType.ObjectRef),
        new("GemAnimator", UIFieldType.ObjectRef),
        new("PendulumAnimator", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
