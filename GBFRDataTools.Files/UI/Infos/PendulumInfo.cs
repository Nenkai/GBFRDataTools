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
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("SetImages", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("Icons", UIFieldType.ObjectRefVector),
        new("Skills", UIFieldType.ObjectRefVector),
        new("EmptyTexts", UIFieldType.ObjectRefVector),
        new("Icon", UIFieldType.ObjectRef),
        new("SkillList", UIFieldType.ObjectRef),
        new("Protection", UIFieldType.ObjectRef),
        new("ProtectionFav", UIFieldType.ObjectRef),
        new("Ticket", UIFieldType.ObjectRef),
        new("RupiInfo", UIFieldType.ObjectRef),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new("Rarity", UIFieldType.ObjectRef),
        new("BgImageSetter", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
