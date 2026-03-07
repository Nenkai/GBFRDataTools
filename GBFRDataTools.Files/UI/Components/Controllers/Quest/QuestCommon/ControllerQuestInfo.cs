using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Controllers.Quest.QuestCommon;

// ui::component::ControllerQuestInfo
public class ControllerQuestInfo : Controller
{
    public UIObjectRef QuestInfo { get; set; }
    public UIObjectRef RewardCanvasGroup { get; set; }
    public UIObjectRef MenuReward { get; set; }
    public UIObjectRef QuestRoot { get; set; }
    public UIObjectRef RewardRoot { get; set; }
    public UIObjectRef ClaerCheck { get; set; } // Cy typo - "Clear" -> "Claer"
    public UIObjectRef Title { get; set; }
    public UIObjectRef ChangePage { get; set; }
    public UIObjectRef PageNo { get; set; }
    public UIObjectRef PageMax { get; set; }
    public UIObjectRef _E9F9BAC0 { get; set; }
}
