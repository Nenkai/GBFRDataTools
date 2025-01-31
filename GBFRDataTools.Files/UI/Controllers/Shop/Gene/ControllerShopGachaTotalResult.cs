using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Shop.Gene;

// ui::component::ControllerShopGachaTotalResult
public class ControllerShopGachaTotalResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", UIFieldType.ObjectRef),
        new(0x22BAEE93, UIFieldType.ObjectRef),
        new(0xDE4276EE, UIFieldType.ObjectRef),
        new("Fever", UIFieldType.ObjectRef), // 0x992108F9
        new("NewExecuteCount", UIFieldType.ObjectRef), // 0x599E9C2F
        new("GaugeObj", UIFieldType.ObjectRef), // 0x3A8F66CD
        new(0x609F0465, UIFieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
