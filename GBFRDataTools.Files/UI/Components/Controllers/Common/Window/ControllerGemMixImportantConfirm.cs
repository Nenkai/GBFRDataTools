using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerGemMixImportantConfirm
public class ControllerGemMixImportantConfirm : Controller
{
    public UIObjectRef MenuCheck { get; set; }
    public UIObjectRef MenuDialog { get; set; }
    public UIObjectRef WarningText { get; set; }
    public UIObjectRef ErrorChoiceText { get; set; }
    public List<UIObjectRef> Gems { get; set; }
}
