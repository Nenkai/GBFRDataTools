using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerBadgeAllRewardDialog
public class ControllerBadgeAllRewardDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Title", FieldType.ObjectRef),
        new("TextObject", FieldType.ObjectRef),
        new("Text", FieldType.ObjectRef),
        new("ErrorObject", FieldType.ObjectRef),
        new("ErrorText1", FieldType.ObjectRef),
        new("ErrorText2", FieldType.ObjectRef),
        new("LineObject", FieldType.ObjectRef),
        new("RupiObject", FieldType.ObjectRef),
        new("RupiResultObject", FieldType.ObjectRef),
        new("RupiBeforeText", FieldType.ObjectRef),
        new("RupiAfterText", FieldType.ObjectRef),
        new("ListControls", FieldType.ObjectRefVector),
        new("Menu", FieldType.ObjectRef),
        new("MenuDialog", FieldType.ObjectRef),
        new("ScrollBar", FieldType.ObjectRef),
        new("ScrollBg", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
