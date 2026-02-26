using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.WinCut;

// ui::component::ControllerWinCutChoice
public class ControllerWinCutChoice : Controller
{
    public UIObjectRef Menu { get; set; }
    public List<UIObjectRef> Elements { get; set; }
    public float OpenControlDelay { get; set; }
    public float FixCallbackDelay { get; set; }
    public UIObjectRef Root { get; set; }
}
