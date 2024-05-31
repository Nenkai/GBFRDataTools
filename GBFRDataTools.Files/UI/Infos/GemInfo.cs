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
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("HideImages", FieldType.ObjectRefVector),
        new("Icon", FieldType.ObjectRef),
        new("Common", FieldType.ObjectRef),
        new("Uncommon", FieldType.ObjectRef),
        new("Rare", FieldType.ObjectRef),
        new("Epic", FieldType.ObjectRef),
        new("Legend", FieldType.ObjectRef),
        new("Rarity", FieldType.ObjectRef),
        new("Names", FieldType.ObjectRefVector),
        new("Levels", FieldType.ObjectRefVector),
        new("SkillLevels", FieldType.ObjectRefVector),
        new("UnitMarks", FieldType.ObjectRefVector),
        new("Level", FieldType.ObjectRef),
        new("Skills", FieldType.ObjectRefVector),
        new("SkillList", FieldType.ObjectRef),
        new("Protection", FieldType.ObjectRef),
        new("ProtectionFav", FieldType.ObjectRef),
        new("Ticket", FieldType.ObjectRef),
        new("ComparedLevel", FieldType.ObjectRef),
        new("ComparedLevelObjs", FieldType.ObjectRefVector),
        new("LvUnit", FieldType.ObjectRefVector),
        new("CanvasGroup", FieldType.ObjectRef),
        new("BgIcon", FieldType.ObjectRef),
        new("BgImageSetter", FieldType.ObjectRef),
        new("EmptyTexts", FieldType.ObjectRefVector),
        new("RupiInfo", FieldType.ObjectRef),
        new("UpdateCharaIcon", FieldType.ObjectRef),
        new("CautionIcon", FieldType.ObjectRef),
        new("Lucifer", FieldType.ObjectRef),
        new("UpdateIcon", FieldType.ObjectRef),

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
