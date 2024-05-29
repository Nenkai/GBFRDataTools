using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::CharaInfo
public class CharaInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x8E1CB3E3, FieldType.ObjectRefVector),
        new(0x930C5152, FieldType.ObjectRef),
        new(0xF272EF26, FieldType.ObjectRef),
        new("Icon", FieldType.ObjectRef),
        new("Names", FieldType.ObjectRefVector),
        new("UpdateIcon", FieldType.ObjectRef),
        new(0x4E129D7C, FieldType.ObjectRef),
        new("Attacks", FieldType.ObjectRefVector),
        new(0x72816E5A, FieldType.ObjectRef),
        new("Levels", FieldType.ObjectRefVector),
        new("ComparedAttackObj", FieldType.ObjectRef),
        new(0xB6BE3C01, FieldType.ObjectRefVector),
        new(0xD5C55338, FieldType.ObjectRef),
        new("ComparedAttack", FieldType.ObjectRef),
        new("Icons", FieldType.ObjectRefVector),
        new(0xE5772903, FieldType.ObjectRef),
        new("Level", FieldType.ObjectRef),
        new("OnlineNameColorSetter", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
