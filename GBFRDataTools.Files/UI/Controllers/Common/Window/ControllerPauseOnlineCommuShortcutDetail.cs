using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerPauseOnlineCommuShortcutDetail
public class ControllerPauseOnlineCommuShortcutDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Resizes", UIFieldType.ObjectRefVector),
        new("StampResizes", UIFieldType.ObjectRefVector),
        new("MenuStamp", UIFieldType.ObjectRef),
        new("MenuFixedPhrase", UIFieldType.ObjectRef),
        new("MenuEmotion", UIFieldType.ObjectRef),
        new("Gauss", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
