using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Popup;

// ui::component::ControllerPopupQuestReadyError
public class ControllerPopup : ControllerPopupBase
{
    public UIObjectRef InfoText { get; set; }
    public UIObjectRef TitleRoot { get; set; }
    public UIObjectRef TitleText { get; set; }
    public UIObjectRef FixShortcut { get; set; }
    public UIObjectRef ItemCursor { get; set; }
    public UIObjectRef SaveIconRoot { get; set; }
    public UIObjectRef SaveIcon { get; set; }
    public List<UIObjectRef> Disables { get; set; }
}
