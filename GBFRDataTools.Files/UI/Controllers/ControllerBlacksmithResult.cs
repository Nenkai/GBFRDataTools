using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerBlacksmithResult
public class ControllerBlacksmithResult // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Info", FieldType.ObjectRef),
        new("MirageInfo", FieldType.ObjectRef),
        new("CharaInfo", FieldType.ObjectRef),
        new("GemInfo", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("InfoObj", FieldType.ObjectRef),
        new("InfoTextRootObj", FieldType.ObjectRef),
        new("InfoText", FieldType.ObjectRef),
        new("InfoNumText", FieldType.ObjectRef),
        new("Lv", FieldType.ObjectRef),
        new("Bonus", FieldType.ObjectRef),
        new("Attack", FieldType.ObjectRef),
        new("Hp", FieldType.ObjectRef),
        new("Fix", FieldType.ObjectRef),
        new("ItemCursor", FieldType.ObjectRef),
        new("MenuDialog", FieldType.ObjectRef),
        new("StatusLvorBonus", FieldType.ObjectRef),
        new("StatusAttack", FieldType.ObjectRef),
        new("StatusHp", FieldType.ObjectRef),
        new("CharaImage", FieldType.ObjectRef),
        new("AnimationEvent", FieldType.ObjectRef),
        new("MspInfo", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
