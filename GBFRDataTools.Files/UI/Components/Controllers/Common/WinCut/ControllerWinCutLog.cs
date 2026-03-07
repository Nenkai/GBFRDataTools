using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.WinCut;

// ui::component::ControllerWinCutLog
public class ControllerWinCutLog : Controller
{
    public List<UIObjectRef> Items { get; set; }
    public UIObjectRef ScrollBar { get; set; }
    public float ScrollTime { get; set; }
    public int ScrollMode { get; set; }
}
