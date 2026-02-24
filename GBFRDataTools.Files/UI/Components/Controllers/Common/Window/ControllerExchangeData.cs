using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerExchangeData
public class ControllerExchangeData : Controller
{
    public List<UIObjectRef> TitleTexts { get; set; }
    public List<UIObjectRef> Resizes { get; set; }
    public UIObjectRef Menu { get; set; }
    public UIObjectRef CurrentData { get; set; }
    public UIObjectRef FuncBtn { get; set; }
    public UIObjectRef ResetBtn { get; set; }
    public int ExchangeMode { get; set; }
}
