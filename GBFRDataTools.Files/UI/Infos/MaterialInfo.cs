using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::MaterialInfo
public class MaterialInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("SetImages", UIFieldType.ObjectRefVector),
        new("RaritySets", UIFieldType.ObjectRefVector),
        new("Icons", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("Counts", UIFieldType.ObjectRefVector),
        new("UnitMarks", UIFieldType.ObjectRefVector),
        new("Infos", UIFieldType.ObjectRefVector),
        new("EmptyTexts", UIFieldType.ObjectRefVector),
        new("MaxCounts", UIFieldType.ObjectRefVector),
        new("MaterialNumTextRootObjs", UIFieldType.ObjectRefVector),
        new("NeedCounts", UIFieldType.ObjectRefVector),
        new("NeedCountTextRootObjs", UIFieldType.ObjectRefVector),
        new("HaveCountTextRootObjs", UIFieldType.ObjectRefVector),
        new("Favorite", UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("Ticket", UIFieldType.ObjectRef),
        new("BgIcon", UIFieldType.ObjectRef),
        new("BgImageSetter", UIFieldType.ObjectRef),
        new("RupiInfo", UIFieldType.ObjectRef),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new("Rarity", UIFieldType.ObjectRef),
        new("UseItem", UIFieldType.ObjectRef),
        new("UseItemText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
