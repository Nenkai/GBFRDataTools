using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Controllers;

// ui::component::ControllerDialog
public class ControllerDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Bg", FieldType.ObjectRef),
        new UIPropertyTypeDef("Texts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("SelectSet", FieldType.ObjectRef),
        new UIPropertyTypeDef("TitleSet", FieldType.ObjectRef),
        new UIPropertyTypeDef("LineSet", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgSet", FieldType.ObjectRef),
        new UIPropertyTypeDef("Title", FieldType.ObjectRef),
        new UIPropertyTypeDef("SingleMenu", FieldType.ObjectRef),
        new UIPropertyTypeDef("MultiMenu", FieldType.ObjectRef),
        new UIPropertyTypeDef("TitleText", FieldType.ObjectRef),
        new UIPropertyTypeDef("InfoTexts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("TitleIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("TitleIconImage", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("InfoTextSet", FieldType.ObjectRef),
        new UIPropertyTypeDef("DifficultySet", FieldType.ObjectRef),
        new UIPropertyTypeDef("Difficulty", FieldType.ObjectRef),
        new UIPropertyTypeDef("StartConfirm", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgGauss", FieldType.ObjectRef),
        new UIPropertyTypeDef("SideIcons", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("AssistIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Layout", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
