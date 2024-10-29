using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.LinkLevel;

// ui::component::ControllerLinkCounter
public class ControllerLinkCounter // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("LinkTimeGauge", UIFieldType.ObjectRef),
        new("TextCondition", UIFieldType.ObjectRef),
        new("TextConditionA", UIFieldType.ObjectRef),
        new("LinkCounterLog", UIFieldType.ObjectRefVector),
        new("LinkTimeChance", UIFieldType.ObjectRefVector),
        new("LinkTimeEff", UIFieldType.ObjectRefVector),
        new("LinkNum001", UIFieldType.ObjectRef),
        new("LinkNum001a", UIFieldType.ObjectRef),
        new("LinkNum010", UIFieldType.ObjectRef),
        new("LinkNum010a", UIFieldType.ObjectRef),
        new("LinkNum100", UIFieldType.ObjectRef),
        new("LinkNum100a", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
