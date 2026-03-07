using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerDialog
public class ControllerDialog : Controller
{
    public UIObjectRef Bg { get; set; }
    public List<UIObjectRef> Texts { get; set; }
    public UIObjectRef SelectSet { get; set; }
    public UIObjectRef TitleSet { get; set; }
    public UIObjectRef LineSet { get; set; }
    public UIObjectRef BgSet { get; set; }
    public UIObjectRef Title { get; set; }
    public UIObjectRef SingleMenu { get; set; }
    public UIObjectRef MultiMenu { get; set; }
    public UIObjectRef TitleText { get; set; }
    public List<UIObjectRef> InfoTexts { get; set; }
    public UIObjectRef TitleIcon { get; set; }
    public List<UIObjectRef> TitleIconImage { get; set; }
    public UIObjectRef InfoTextSet { get; set; }
    public UIObjectRef DifficultySet { get; set; }
    public UIObjectRef Difficulty { get; set; }
    public UIObjectRef StartConfirm { get; set; }
    public UIObjectRef BgGauss { get; set; }
    public List<UIObjectRef> SideIcons { get; set; }
    public UIObjectRef AssistIcon { get; set; }
    public UIObjectRef Layout { get; set; }
}
