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
        new UIPropertyTypeDef("Sets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Empties", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("SetImages", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("RaritySets", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Icons", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Names", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Counts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("UnitMarks", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Infos", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("EmptyTexts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("MaxCounts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("MaterialNumTextRootObjs", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("NeedCounts", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("NeedCountTextRootObjs", FieldType.ObjectRef),
        new UIPropertyTypeDef("HaveCountTextRootObjs", FieldType.ObjectRef),
        new UIPropertyTypeDef("Favorite", FieldType.ObjectRef),
        new UIPropertyTypeDef("Icon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Ticket", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("BgImageSetter", FieldType.ObjectRef),
        new UIPropertyTypeDef("RupiInfo", FieldType.ObjectRef),
        new UIPropertyTypeDef("UpdateIcon", FieldType.ObjectRef),
        new UIPropertyTypeDef("Rarity", FieldType.ObjectRef),
        new UIPropertyTypeDef("UseItem", FieldType.ObjectRef),
        new UIPropertyTypeDef("UseItemText", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
