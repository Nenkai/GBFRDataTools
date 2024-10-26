using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.WinCut;

// ui::component::ControllerWinCut
public class ControllerWinCut // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("Name", UIFieldType.ObjectRef),
        new("Text", UIFieldType.ObjectRef),
        new("Auto", UIFieldType.ObjectRef),
        new("Skip", UIFieldType.ObjectRef),
        new("ToLog", UIFieldType.ObjectRef),
        new("ToWord", UIFieldType.ObjectRef),
        new("ToWordText", UIFieldType.ObjectRef),
        new("AutoButton", UIFieldType.ObjectRef),
        new("WordButton", UIFieldType.ObjectRef),
        new("LogButton", UIFieldType.ObjectRef),
        new("Cursor", UIFieldType.ObjectRef),
        new("TextObj", UIFieldType.ObjectRef),
        new("WordObj", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
