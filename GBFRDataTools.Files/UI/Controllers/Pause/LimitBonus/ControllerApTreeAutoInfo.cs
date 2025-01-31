using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.LimitBonus;

// ui::component::ControllerApTreeAutoInfo
public class ControllerApTreeAutoInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("AbilityObj", UIFieldType.ObjectRef),
        new("StatusObj", UIFieldType.ObjectRef),
        new("ApTitleText", UIFieldType.ObjectRef),
        new("AbilityApInfo", UIFieldType.ObjectRef),
        new("StatusApInfo", UIFieldType.ObjectRef),
        new("TotalCost", UIFieldType.ObjectRef),
        new("Fixed", UIFieldType.ObjectRef),
        new("GuideText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
