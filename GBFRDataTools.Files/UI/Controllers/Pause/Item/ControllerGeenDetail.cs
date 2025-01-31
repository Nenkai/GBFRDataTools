using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Item;

// ui::component::ControllerGeenDetail
public class ControllerGeenDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("Geen", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("PersonalInfo", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Charas", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Visibles", UIFieldType.ObjectRefVector),
        new UIPropertyTypeDef("Hides", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
