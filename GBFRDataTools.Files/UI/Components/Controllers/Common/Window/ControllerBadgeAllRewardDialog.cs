using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Common.Window;

// ui::component::ControllerBadgeAllRewardDialog
public class ControllerBadgeAllRewardDialog : Controller
{
    public UIObjectRef Title { get; set; }
    public UIObjectRef TextObject { get; set; }
    public UIObjectRef Text { get; set; }
    public UIObjectRef ErrorObject { get; set; }
    public UIObjectRef ErrorText1 { get; set; }
    public UIObjectRef ErrorText2 { get; set; }
    public UIObjectRef LineObject { get; set; }
    public UIObjectRef RupiObject { get; set; }
    public UIObjectRef RupiResultObject { get; set; }
    public UIObjectRef RupiBeforeText { get; set; }
    public UIObjectRef RupiAfterText { get; set; }
    public List<UIObjectRef> ListControls { get; set; }
    public UIObjectRef Menu { get; set; }
    public UIObjectRef MenuDialog { get; set; }
    public UIObjectRef ScrollBar { get; set; }
    public UIObjectRef ScrollBg { get; set; }
}
