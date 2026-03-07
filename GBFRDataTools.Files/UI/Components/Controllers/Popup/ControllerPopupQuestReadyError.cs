using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Popup;

// ui::component::ControllerPopupQuestReadyError
public class ControllerPopupQuestReadyError : ControllerPopupBase
{
    public UIObjectRef Title { get; set; }
    public UIObjectRef TitleSet { get; set; }
    public UIObjectRef NgReason { get; set; }
    public List<UIObjectRef> NgPlayerNames { get; set; }
    public UIObjectRef Fix { get; set; }
    public UIObjectRef Cursor { get; set; }
}
