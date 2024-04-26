using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::GemInfo
public class GemInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Sets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Empties", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("HideImages", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Common", FieldType.ObjectRef),
        new UIPropertyTypeDef("Uncommon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Rare", FieldType.ObjectRef),
        new UIPropertyTypeDef("Epic", FieldType.ObjectRef),
        new UIPropertyTypeDef("Legend", FieldType.ObjectRef),
        new UIPropertyTypeDef("Rarity", FieldType.ObjectRef),
        new UIPropertyTypeDef("Names", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Levels", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("SkillLevels", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("UnitMarks", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Level", FieldType.ObjectRef),
        new UIPropertyTypeDef("Skills", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("SkillList", FieldType.ObjectRef),
        new UIPropertyTypeDef("Protection", FieldType.ObjectRef),
        new UIPropertyTypeDef("ProtectionFav", FieldType.ObjectRef),
        new UIPropertyTypeDef("Ticket", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedLevel", FieldType.ObjectRef),
        new UIPropertyTypeDef("ComparedLevelObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("LvUnit", FieldType.ObjectRef),
        new UIPropertyTypeDef("CanvasGroup", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgImageSetter", FieldType.ObjectRef),
        new UIPropertyTypeDef("EmptyTexts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("RupiInfo", FieldType.ObjectRef),
        new UIPropertyTypeDef("UpdateCharaIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("CautionIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Lucifer", FieldType.ObjectRef), // Not part of structure?

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
