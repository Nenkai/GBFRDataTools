using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.ChallengeMission;

// ui::component::ControllerChallengeMissionInfo
public class ControllerChallengeMissionInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Info", UIFieldType.ObjectRef),
        new("Progress", UIFieldType.ObjectRef),
        new("ProgressArc", UIFieldType.ObjectRef),
        new("Reward", UIFieldType.ObjectRef),
        new("ProgressObj", UIFieldType.ObjectRef),
        new("TargetCountText", UIFieldType.ObjectRef),
        new("NowCountText", UIFieldType.ObjectRef),
        new("Complete", UIFieldType.ObjectRef),
        new("NotItemReward", UIFieldType.ObjectRef),
        new("ButtonGuide", UIFieldType.ObjectRef),
        new("InfoContentObj", UIFieldType.ObjectRef),
        new("Sets1", UIFieldType.ObjectRefVector),
        new("Sets2", UIFieldType.ObjectRefVector),
        new("MspSets1", UIFieldType.ObjectRefVector),
        new("MspSets2", UIFieldType.ObjectRefVector),
        new("BothSets", UIFieldType.ObjectRefVector),
        new("EitherSets", UIFieldType.ObjectRefVector),
        new("Icons1", UIFieldType.ObjectRefVector),
        new("Icons2", UIFieldType.ObjectRefVector),
        new("TitleTexts1", UIFieldType.ObjectRefVector),
        new("TitleTexts2", UIFieldType.ObjectRefVector),
        new("ValueTexts1", UIFieldType.ObjectRefVector),
        new("ValueTexts2", UIFieldType.ObjectRefVector),
        new("ItemQuestSets", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
