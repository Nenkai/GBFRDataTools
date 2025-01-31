using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Ability;

// ui::component::ControllerAbilityInfo01_01
public class ControllerAbilityInfo01_01 // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Chara", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
