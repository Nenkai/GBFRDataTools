using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Hud.TrialBattle;

// ui::component::ControllerTrialSettingList
public class ControllerTrialSettingList : Controller
{
    public UIObjectRef Root { get; set; }
    public UIObjectRef MenuTab { get; set; }
    public UIObjectRef MenuSetting { get; set; }
    public UIObjectRef MenuChoice { get; set; }
    public UIObjectRef Info { get; set; }
    public UIObjectRef Reset { get; set; }
    public UIObjectRef Left { get; set; }
    public UIObjectRef Right { get; set; }
    public List<UIObjectRef> Badges { get; set; }
    public List<UIObjectRef> BadgeTexts { get; set; }
}
