using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerBadgeAllRewardDialog
public class ControllerBadgeAllRewardDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Title", UIFieldType.ObjectRef),
        new("TextObject", UIFieldType.ObjectRef),
        new("Text", UIFieldType.ObjectRef),
        new("ErrorObject", UIFieldType.ObjectRef),
        new("ErrorText1", UIFieldType.ObjectRef),
        new("ErrorText2", UIFieldType.ObjectRef),
        new("LineObject", UIFieldType.ObjectRef),
        new("RupiObject", UIFieldType.ObjectRef),
        new("RupiResultObject", UIFieldType.ObjectRef),
        new("RupiBeforeText", UIFieldType.ObjectRef),
        new("RupiAfterText", UIFieldType.ObjectRef),
        new("ListControls", UIFieldType.ObjectRefVector),
        new("Menu", UIFieldType.ObjectRef),
        new("MenuDialog", UIFieldType.ObjectRef),
        new("ScrollBar", UIFieldType.ObjectRef),
        new("ScrollBg", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
