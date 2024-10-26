using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Blacksmith;

// ui::component::ControllerBlacksmithResult
public class ControllerBlacksmithResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Info", UIFieldType.ObjectRef),
        new("MirageInfo", UIFieldType.ObjectRef),
        new("CharaInfo", UIFieldType.ObjectRef),
        new("GemInfo", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("InfoObj", UIFieldType.ObjectRef),
        new("InfoTextRootObj", UIFieldType.ObjectRef),
        new("InfoText", UIFieldType.ObjectRef),
        new("InfoNumText", UIFieldType.ObjectRef),
        new("Lv", UIFieldType.ObjectRef),
        new("Bonus", UIFieldType.ObjectRef),
        new("Attack", UIFieldType.ObjectRef),
        new("Hp", UIFieldType.ObjectRef),
        new("Fix", UIFieldType.ObjectRef),
        new("ItemCursor", UIFieldType.ObjectRef),
        new("MenuDialog", UIFieldType.ObjectRef),
        new("StatusLvorBonus", UIFieldType.ObjectRef),
        new("StatusAttack", UIFieldType.ObjectRef),
        new("StatusHp", UIFieldType.ObjectRef),
        new("CharaImage", UIFieldType.ObjectRef),
        new("AnimationEvent", UIFieldType.ObjectRef),
        new("MspInfo", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
