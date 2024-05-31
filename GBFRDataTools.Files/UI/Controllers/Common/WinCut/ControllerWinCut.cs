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
        new("Root", FieldType.ObjectRef),
        new("Name", FieldType.ObjectRef),
        new("Text", FieldType.ObjectRef),
        new("Auto", FieldType.ObjectRef),
        new("Skip", FieldType.ObjectRef),
        new("ToLog", FieldType.ObjectRef),
        new("ToWord", FieldType.ObjectRef),
        new("ToWordText", FieldType.ObjectRef),
        new("AutoButton", FieldType.ObjectRef),
        new("WordButton", FieldType.ObjectRef),
        new("LogButton", FieldType.ObjectRef),
        new("Cursor", FieldType.ObjectRef),
        new("TextObj", FieldType.ObjectRef),
        new("WordObj", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
