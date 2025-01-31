using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Quest.QuestCommon;

// ui::component::ControllerQuestInfo
public class ControllerQuestInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("QuestInfo", UIFieldType.ObjectRef),
        new("RewardCanvasGroup", UIFieldType.ObjectRef),
        new("MenuReward", UIFieldType.ObjectRef),
        new("QuestRoot", UIFieldType.ObjectRef),
        new("RewardRoot", UIFieldType.ObjectRef),
        new("ClaerCheck", UIFieldType.ObjectRef), // Cy typo - "Clear" -> "Claer"
        new("Title", UIFieldType.ObjectRef),
        new("ChangePage", UIFieldType.ObjectRef),
        new("PageNo", UIFieldType.ObjectRef),
        new("PageMax", UIFieldType.ObjectRef),
        new(0xE9F9BAC0, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
