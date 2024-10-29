using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.PlParameter;

// ui::component::ControllerPlParameterTown
public class ControllerPlParameterTown // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("CharaInfo", UIFieldType.ObjectRef),
        new("LevelUp", UIFieldType.ObjectRef),
        new("CharaIcons", UIFieldType.ObjectRefVector),
        new("CharaPainIcon", UIFieldType.ObjectRef),
        new("RootObject", UIFieldType.ObjectRef),
        new("LeaderIconObject", UIFieldType.ObjectRef),
        new("Name", UIFieldType.ObjectRef),
        new("OnlineName", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
