using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Ability;

// ui::component::ControllerAbilityInfo01_02
public class ControllerAbilityInfo01_02 // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Chara", UIFieldType.ObjectRef),
        new("AbilityInfos", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
