using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GaugeContents;

// ui::component::ControllerGaugeBattleNotice
public class ControllerGaugeBattleNotice // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", FieldType.ObjectRef),
        new("Cursor", FieldType.ObjectRef),
        new("ChangeColor01", FieldType.ObjectRef),
        new("ChangeColor02", FieldType.ObjectRef),
        new("GaugeMask", FieldType.ObjectRef),
        new("GaugesImageSetter", FieldType.ObjectRefVector),
        new("TextNormal", FieldType.ObjectRef),
        new("TextPurple", FieldType.ObjectRef),
        new("TextYellow", FieldType.ObjectRef),
        new("TextChant", FieldType.ObjectRef),
        new("CursorPosMin", FieldType.F32),
        new("CursorPosMax", FieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
