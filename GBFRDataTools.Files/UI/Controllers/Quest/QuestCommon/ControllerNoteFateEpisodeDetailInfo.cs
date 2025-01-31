using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Quest.QuestCommon;

// ui::component::ControllerNoteFateEpisodeDetailInfo
public class ControllerNoteFateEpisodeDetailInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("UnlockObjects", UIFieldType.ObjectRefVector),
        new("UnlockIcons", UIFieldType.ObjectRefVector),
        new("UnlockBgs", UIFieldType.ObjectRefVector),
        new("UnlockTexts", UIFieldType.ObjectRefVector),
        new("DetailInfoSwitch", UIFieldType.ObjectRef),
        new("CheckIcon", UIFieldType.ObjectRef),
        new("EpisodeUnlock", UIFieldType.ObjectRef),
        new("InfoRoot", UIFieldType.ObjectRef),
        new("StatusInfo", UIFieldType.ObjectRef),
        new("UnlockInfo", UIFieldType.ObjectRef),
        new("UnlockGemInfo", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("HpStatusNumText", UIFieldType.ObjectRef),
        new("AttackStatusNumText", UIFieldType.ObjectRef),
        new("UnlockInfoText", UIFieldType.ObjectRef),
        new("UnlockGemInfoText", UIFieldType.ObjectRef),
        new("PageNowText", UIFieldType.ObjectRef),
        new("PageMaxText", UIFieldType.ObjectRef),
        new("RewardCanvas", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
