using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Pause.ChallengeMission;

// ui::component::ControllerChallengeMissionInfo
public class ControllerChallengeMissionInfo : Controller
{
    public UIObjectRef Info { get; set; }
    public UIObjectRef Progress { get; set; }
    public UIObjectRef ProgressArc { get; set; }
    public UIObjectRef Reward { get; set; }
    public UIObjectRef ProgressObj { get; set; }
    public UIObjectRef TargetCountText { get; set; }
    public UIObjectRef NowCountText { get; set; }
    public UIObjectRef Complete { get; set; }
    public UIObjectRef NotItemReward { get; set; }
    public UIObjectRef ButtonGuide { get; set; }
    public UIObjectRef InfoContentObj { get; set; }
    public List<UIObjectRef> Sets1 { get; set; }
    public List<UIObjectRef> Sets2 { get; set; }
    public List<UIObjectRef> MspSets1 { get; set; }
    public List<UIObjectRef> MspSets2 { get; set; }
    public List<UIObjectRef> BothSets { get; set; }
    public List<UIObjectRef> EitherSets { get; set; }
    public List<UIObjectRef> Icons1 { get; set; }
    public List<UIObjectRef> Icons2 { get; set; }
    public List<UIObjectRef> TitleTexts1 { get; set; }
    public List<UIObjectRef> TitleTexts2 { get; set; }
    public List<UIObjectRef> ValueTexts1 { get; set; }
    public List<UIObjectRef> ValueTexts2 { get; set; }
    public List<UIObjectRef> ItemQuestSets { get; set; }
}
