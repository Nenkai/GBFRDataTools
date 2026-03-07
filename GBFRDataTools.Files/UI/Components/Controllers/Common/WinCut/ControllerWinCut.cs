using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.WinCut;

// ui::component::ControllerWinCut
public class ControllerWinCut : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef Name { get; set; }
    public UIObjectRef Text { get; set; }
    public UIObjectRef Auto { get; set; }
    public UIObjectRef Skip { get; set; }
    public UIObjectRef ToLog { get; set; }
    public UIObjectRef ToWord { get; set; }
    public UIObjectRef ToWordText { get; set; }
    public UIObjectRef AutoButton { get; set; }
    public UIObjectRef WordButton { get; set; }
    public UIObjectRef LogButton { get; set; }
    public UIObjectRef Cursor { get; set; }
    public UIObjectRef TextObj { get; set; }
    public UIObjectRef WordObj { get; set; }
}
