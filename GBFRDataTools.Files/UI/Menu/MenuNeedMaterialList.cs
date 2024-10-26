using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuNeedMaterialList
public class MenuNeedMaterialList // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Mode", UIFieldType.S32),
        new("Left", UIFieldType.ObjectRef),
        new("Right", UIFieldType.ObjectRef),
        new("RupiInfo", UIFieldType.ObjectRef),
        new("Weapon", UIFieldType.ObjectRef),
        new("Chara", UIFieldType.ObjectRef),
        new("Geen", UIFieldType.ObjectRef),
        new("Trade", UIFieldType.ObjectRef),
        new("Exp", UIFieldType.ObjectRef),
        new("Lb", UIFieldType.ObjectRef),
        new("LbLine", UIFieldType.ObjectRef),
        new("PreGetLBInfoRoot", UIFieldType.ObjectRef),
        new("ViewInvalid", UIFieldType.Bool),
        new("ConditionActive", UIFieldType.ObjectRefVector),
        new("ConditionInactive", UIFieldType.ObjectRefVector),
        new("Dials", UIFieldType.ObjectRefVector),
        new("WarningObj", UIFieldType.ObjectRef),
        new("ConditionText", UIFieldType.ObjectRef),
        new("GuideCheckMaterial", UIFieldType.ObjectRef),
        new("MspInfo", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
