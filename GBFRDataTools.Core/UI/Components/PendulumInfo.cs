using GBFRDataTools.Core.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::PendulumInfo
public class PendulumInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Sets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Empties", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("SetImages", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Names", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icons", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Skills", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("EmptyTexts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icon", FieldType.ObjectRef),
        new UIPropertyTypeDef("SkillList", FieldType.ObjectRef),
        new UIPropertyTypeDef("Protection", FieldType.ObjectRef),
        new UIPropertyTypeDef("ProtectionFav", FieldType.ObjectRef),
        new UIPropertyTypeDef("Ticket", FieldType.ObjectRef),
        new UIPropertyTypeDef("RupiInfo", FieldType.ObjectRef),
        new UIPropertyTypeDef("UpdateIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Rarity", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
