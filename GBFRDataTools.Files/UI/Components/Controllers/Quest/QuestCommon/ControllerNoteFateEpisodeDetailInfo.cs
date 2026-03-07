using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Quest.QuestCommon;

// ui::component::ControllerNoteFateEpisodeDetailInfo
public class ControllerNoteFateEpisodeDetailInfo : Controller
{
    public List<UIObjectRef> UnlockObjects { get; set; }
    public List<UIObjectRef> UnlockIcons { get; set; }
    public List<UIObjectRef> UnlockBgs { get; set; }
    public List<UIObjectRef> UnlockTexts { get; set; }
    public UIObjectRef DetailInfoSwitch { get; set; }
    public UIObjectRef CheckIcon { get; set; }
    public UIObjectRef EpisodeUnlock { get; set; }
    public UIObjectRef InfoRoot { get; set; }
    public UIObjectRef StatusInfo { get; set; }
    public UIObjectRef UnlockInfo { get; set; }
    public UIObjectRef UnlockGemInfo { get; set; }
    public UIObjectRef TitleText { get; set; }
    public UIObjectRef HpStatusNumText { get; set; }
    public UIObjectRef AttackStatusNumText { get; set; }
    public UIObjectRef UnlockInfoText { get; set; }
    public UIObjectRef UnlockGemInfoText { get; set; }
    public UIObjectRef PageNowText { get; set; }
    public UIObjectRef PageMaxText { get; set; }
    public UIObjectRef RewardCanvas { get; set; }
}
