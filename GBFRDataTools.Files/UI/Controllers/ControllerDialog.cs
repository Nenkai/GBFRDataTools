using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerDialog
public class ControllerDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Bg", FieldType.ObjectRef),
        new("Texts", FieldType.ObjectRefVector),
        new("SelectSet", FieldType.ObjectRef),
        new("TitleSet", FieldType.ObjectRef),
        new("LineSet", FieldType.ObjectRef),
        new("BgSet", FieldType.ObjectRef),
        new("Title", FieldType.ObjectRef),
        new("SingleMenu", FieldType.ObjectRef),
        new("MultiMenu", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("InfoTexts", FieldType.ObjectRefVector),
        new("TitleIcon", FieldType.ObjectRef),
        new("TitleIconImage", FieldType.ObjectRefVector),
        new("InfoTextSet", FieldType.ObjectRef),
        new("DifficultySet", FieldType.ObjectRef),
        new("Difficulty", FieldType.ObjectRef),
        new("StartConfirm", FieldType.ObjectRef),
        new("BgGauss", FieldType.ObjectRef),
        new("SideIcons", FieldType.ObjectRefVector),
        new("AssistIcon", FieldType.ObjectRef),
        new("Layout", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
