using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.GaugeContents;

// ui::component::ControllerGaugeBattleNotice
public class ControllerGaugeBattleNotice : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Cursor { get; set; }
    public UIObjectRef ChangeColor01 { get; set; }
    public UIObjectRef ChangeColor02 { get; set; }
    public UIObjectRef GaugeMask { get; set; }
    public List<UIObjectRef> GaugesImageSetter { get; set; }
    public UIObjectRef TextNormal { get; set; }
    public UIObjectRef TextPurple { get; set; }
    public UIObjectRef TextYellow { get; set; }
    public UIObjectRef TextChant { get; set; }
    public float CursorPosMin { get; set; }
    public float CursorPosMax { get; set; }
}
