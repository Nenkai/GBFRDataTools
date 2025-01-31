using GBFRDataTools.Files.UI.Infos;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.LimitBonus;

// ui::component::ControllerApTreeDetailInfo
public class ControllerApTreeDetailInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("CostTexts", UIFieldType.ObjectRefVector),
        new("ReleaseHides", UIFieldType.ObjectRefVector),
        new("NotPossessText", UIFieldType.ObjectRef),
        new("ContentObj", UIFieldType.ObjectRef),
        new("AbilityObj", UIFieldType.ObjectRef),
        new("SkillObj", UIFieldType.ObjectRef),
        new("ParamIcon", UIFieldType.ObjectRef),
        new("AbilityIcon", UIFieldType.ObjectRef),
        new("WeaponLockNote", UIFieldType.ObjectRef),
        new("GuideAcquire", UIFieldType.ObjectRef),
        new("GuideDetail", UIFieldType.ObjectRef),
        new("GuideAcquireCondition", UIFieldType.ObjectRef),
        new("AcquiredText", UIFieldType.ObjectRef),
        new("ApTitleText", UIFieldType.ObjectRef),
        new("GuideText", UIFieldType.ObjectRef),
        new("NoteTitleText", UIFieldType.ObjectRef),
        new("NoteText", UIFieldType.ObjectRef),
        new("LbInfo", UIFieldType.ObjectRef),
        new("AbilityInfo", UIFieldType.ObjectRef),
        new("ApInfo", UIFieldType.ObjectRef),
        new("GaugeMask", UIFieldType.ObjectRef),
        new("GaugeObj", UIFieldType.ObjectRef),
        new("CostMspObj", UIFieldType.ObjectRef),
        new("CostMspObj02", UIFieldType.ObjectRef),
        new("TotalCost", UIFieldType.ObjectRef),
        new("AbilityDetail", UIFieldType.ObjectRef),
        new("FixedShortcut", UIFieldType.ObjectRef),
        new("InfoDetail", UIFieldType.ObjectRef),
        new("InfoText", UIFieldType.ObjectRef),
        new("AutoCostText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
