using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::PendulumInfo
public class PendulumInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("SetImages", FieldType.ObjectRefVector),
        new("Names", FieldType.ObjectRefVector),
        new("Icons", FieldType.ObjectRefVector),
        new("Skills", FieldType.ObjectRefVector),
        new("EmptyTexts", FieldType.ObjectRefVector),
        new("Icon", FieldType.ObjectRef),
        new("SkillList", FieldType.ObjectRef),
        new("Protection", FieldType.ObjectRef),
        new("ProtectionFav", FieldType.ObjectRef),
        new("Ticket", FieldType.ObjectRef),
        new("RupiInfo", FieldType.ObjectRef),
        new("UpdateIcon", FieldType.ObjectRef),
        new("Rarity", FieldType.ObjectRef),
        new("BgImageSetter", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
