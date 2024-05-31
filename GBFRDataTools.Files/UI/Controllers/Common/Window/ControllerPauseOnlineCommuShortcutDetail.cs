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
        new("Resizes", FieldType.ObjectRefVector),
        new("StampResizes", FieldType.ObjectRefVector),
        new("MenuStamp", FieldType.ObjectRef),
        new("MenuFixedPhrase", FieldType.ObjectRef),
        new("MenuEmotion", FieldType.ObjectRef),
        new("Gauss", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
