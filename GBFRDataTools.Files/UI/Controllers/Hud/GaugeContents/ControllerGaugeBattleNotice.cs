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
        new("Root", UIFieldType.ObjectRef),
        new("Cursor", UIFieldType.ObjectRef),
        new("ChangeColor01", UIFieldType.ObjectRef),
        new("ChangeColor02", UIFieldType.ObjectRef),
        new("GaugeMask", UIFieldType.ObjectRef),
        new("GaugesImageSetter", UIFieldType.ObjectRefVector),
        new("TextNormal", UIFieldType.ObjectRef),
        new("TextPurple", UIFieldType.ObjectRef),
        new("TextYellow", UIFieldType.ObjectRef),
        new("TextChant", UIFieldType.ObjectRef),
        new("CursorPosMin", UIFieldType.F32),
        new("CursorPosMax", UIFieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
