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
        new("Mode", FieldType.S32),
        new("Left", FieldType.ObjectRef),
        new("Right", FieldType.ObjectRef),
        new("RupiInfo", FieldType.ObjectRef),
        new("Weapon", FieldType.ObjectRef),
        new("Chara", FieldType.ObjectRef),
        new("Geen", FieldType.ObjectRef),
        new("Trade", FieldType.ObjectRef),
        new("Exp", FieldType.ObjectRef),
        new("Lb", FieldType.ObjectRef),
        new("LbLine", FieldType.ObjectRef),
        new("PreGetLBInfoRoot", FieldType.ObjectRef),
        new("ViewInvalid", FieldType.Bool),
        new("ConditionActive", FieldType.ObjectRefVector),
        new("ConditionInactive", FieldType.ObjectRefVector),
        new("Dials", FieldType.ObjectRefVector),
        new("WarningObj", FieldType.ObjectRef),
        new("ConditionText", FieldType.ObjectRef),
        new("GuideCheckMaterial", FieldType.ObjectRef),
        new("MspInfo", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
