using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerDialog
public class ControllerDialog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Bg", UIFieldType.ObjectRef),
        new("Texts", UIFieldType.ObjectRefVector),
        new("SelectSet", UIFieldType.ObjectRef),
        new("TitleSet", UIFieldType.ObjectRef),
        new("LineSet", UIFieldType.ObjectRef),
        new("BgSet", UIFieldType.ObjectRef),
        new("Title", UIFieldType.ObjectRef),
        new("SingleMenu", UIFieldType.ObjectRef),
        new("MultiMenu", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("InfoTexts", UIFieldType.ObjectRefVector),
        new("TitleIcon", UIFieldType.ObjectRef),
        new("TitleIconImage", UIFieldType.ObjectRefVector),
        new("InfoTextSet", UIFieldType.ObjectRef),
        new("DifficultySet", UIFieldType.ObjectRef),
        new("Difficulty", UIFieldType.ObjectRef),
        new("StartConfirm", UIFieldType.ObjectRef),
        new("BgGauss", UIFieldType.ObjectRef),
        new("SideIcons", UIFieldType.ObjectRefVector),
        new("AssistIcon", UIFieldType.ObjectRef),
        new("Layout", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
