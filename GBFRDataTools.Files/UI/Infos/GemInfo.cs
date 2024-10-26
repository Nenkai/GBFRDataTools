using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::GemInfo
public class GemInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("HideImages", UIFieldType.ObjectRefVector),
        new("Icon", UIFieldType.ObjectRef),
        new("Common", UIFieldType.ObjectRef),
        new("Uncommon", UIFieldType.ObjectRef),
        new("Rare", UIFieldType.ObjectRef),
        new("Epic", UIFieldType.ObjectRef),
        new("Legend", UIFieldType.ObjectRef),
        new("Rarity", UIFieldType.ObjectRef),
        new("Names", UIFieldType.ObjectRefVector),
        new("Levels", UIFieldType.ObjectRefVector),
        new("SkillLevels", UIFieldType.ObjectRefVector),
        new("UnitMarks", UIFieldType.ObjectRefVector),
        new("Level", UIFieldType.ObjectRef),
        new("Skills", UIFieldType.ObjectRefVector),
        new("SkillList", UIFieldType.ObjectRef),
        new("Protection", UIFieldType.ObjectRef),
        new("ProtectionFav", UIFieldType.ObjectRef),
        new("Ticket", UIFieldType.ObjectRef),
        new("ComparedLevel", UIFieldType.ObjectRef),
        new("ComparedLevelObjs", UIFieldType.ObjectRefVector),
        new("LvUnit", UIFieldType.ObjectRefVector),
        new("CanvasGroup", UIFieldType.ObjectRef),
        new("BgIcon", UIFieldType.ObjectRef),
        new("BgImageSetter", UIFieldType.ObjectRef),
        new("EmptyTexts", UIFieldType.ObjectRefVector),
        new("RupiInfo", UIFieldType.ObjectRef),
        new("UpdateCharaIcon", UIFieldType.ObjectRef),
        new("CautionIcon", UIFieldType.ObjectRef),
        new("Lucifer", UIFieldType.ObjectRef),
        new("UpdateIcon", UIFieldType.ObjectRef),

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
