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
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("SetImages", FieldType.ObjectRefVector),
        new("RaritySets", FieldType.ObjectRefVector),
        new("Icons", FieldType.ObjectRefVector),
        new("Names", FieldType.ObjectRefVector),
        new("Counts", FieldType.ObjectRefVector),
        new("UnitMarks", FieldType.ObjectRefVector),
        new("Infos", FieldType.ObjectRefVector),
        new("EmptyTexts", FieldType.ObjectRefVector),
        new("MaxCounts", FieldType.ObjectRefVector),
        new("MaterialNumTextRootObjs", FieldType.ObjectRefVector),
        new("NeedCounts", FieldType.ObjectRefVector),
        new("NeedCountTextRootObjs", FieldType.ObjectRefVector),
        new("HaveCountTextRootObjs", FieldType.ObjectRefVector),
        new("Favorite", FieldType.ObjectRef),
        new("Icon", FieldType.ObjectRef),
        new("Ticket", FieldType.ObjectRef),
        new("BgIcon", FieldType.ObjectRef),
        new("BgImageSetter", FieldType.ObjectRef),
        new("RupiInfo", FieldType.ObjectRef),
        new("UpdateIcon", FieldType.ObjectRef),
        new("Rarity", FieldType.ObjectRef),
        new("UseItem", FieldType.ObjectRef),
        new("UseItemText", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
