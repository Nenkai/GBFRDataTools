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
        new("Sets", UIFieldType.ObjectRefVector), // D0A7B41
        new("Empties", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector), // 2804DF25
        new("Unlocks", UIFieldType.ObjectRefVector),
        new("Locks", UIFieldType.ObjectRefVector),
        new("Icons", UIFieldType.ObjectRefVector), // DC9652A6
        new("Masks", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector), // A8C20CB5
        new("Levels", UIFieldType.ObjectRefVector), // 8BF2A1C7
        new("Hps", UIFieldType.ObjectRefVector),
        new("HpMaxs", UIFieldType.ObjectRefVector),
        new("Attacks", UIFieldType.ObjectRefVector), // 4F8578FA
        new("Criticals", UIFieldType.ObjectRefVector),
        new("Breaks", UIFieldType.ObjectRefVector),
        new("Powers", UIFieldType.ObjectRefVector),
        new("Ability", UIFieldType.ObjectRefVector),
        new("Gem", UIFieldType.ObjectRefVector),
        new("UniqueSkill", UIFieldType.ObjectRefVector),
        new("SkillInfo", UIFieldType.ObjectRefVector),
        new(0x98A795D6, UIFieldType.ObjectRefVector),
        new(0x8E1CB3E3, UIFieldType.ObjectRefVector),
        new(0x5E626A07, UIFieldType.ObjectRefVector),
        new(0x0BC8E8E8, UIFieldType.ObjectRefVector),
        new("LvUnit", UIFieldType.ObjectRefVector),
        new(0x9C5D8806, UIFieldType.ObjectRefVector),
        new(0xE0D72E02, UIFieldType.ObjectRefVector),
        new(0x04118DA0, UIFieldType.ObjectRefVector),
        new(0xC125A813, UIFieldType.ObjectRefVector),
        new(0xB00E6317, UIFieldType.ObjectRefVector),
        new(0x6F3FE715, UIFieldType.ObjectRefVector),
        new("FateInfo", UIFieldType.ObjectRefVector),
        new("Elements", UIFieldType.ObjectRefVector), // 1C864810

        new(0x37098A79, UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef), // F2856FD4
        new("GlowNew", UIFieldType.ObjectRef),
        new("Player", UIFieldType.ObjectRef),
        new("PlayerKindIcon", UIFieldType.ObjectRef),
        new("UpdateIcon", UIFieldType.ObjectRef), // CFFD7733
        new("Info", UIFieldType.ObjectRef),
        new("Level", UIFieldType.ObjectRef), // F5F92FCB
        new(0xBAA874E4, UIFieldType.ObjectRef),
        new(0xB70C0900, UIFieldType.ObjectRef),
        new(0x20C879BB, UIFieldType.ObjectRef),
        new(0x14595171, UIFieldType.ObjectRef),
        new(0xFCBB93B8, UIFieldType.ObjectRef),
        new(0xD4426534, UIFieldType.ObjectRef),
        new(0x7F95B974, UIFieldType.ObjectRef),
        new(0x54455C21, UIFieldType.ObjectRef),
        new(0x51029910, UIFieldType.ObjectRef),
        new(0xB97CEBC4, UIFieldType.ObjectRef),
        new("Weapon", UIFieldType.ObjectRef),
        new("FavoriteIcon", UIFieldType.ObjectRef),
        new("FriendIcon", UIFieldType.ObjectRef),
        new(0x95F351C9, UIFieldType.ObjectRef),
        new(0x25B6908C, UIFieldType.ObjectRef),
        new(0x930C5152, UIFieldType.ObjectRef),
        new(0xF272EF26, UIFieldType.ObjectRef),
        new(0x72816E5A, UIFieldType.ObjectRef),
        new(0xD5C55338, UIFieldType.ObjectRef),
        new("ComparedAttack", UIFieldType.ObjectRef),
        new(0x867A1FA6, UIFieldType.ObjectRef),
        new("OnlineNameColorSetter", UIFieldType.ObjectRef), // B3CE7BF1
        new(0xE5772903, UIFieldType.ObjectRef),
        new(0x4E129D7C, UIFieldType.ObjectRef), 
        new("ComparedAttackObj", UIFieldType.ObjectRef), // 90D0966A
        new(0x9FE774F6, UIFieldType.ObjectRef),
        new("PowerInfo", UIFieldType.ObjectRef),
        new("LockInfo", UIFieldType.ObjectRef),
        new(0xB91E939A, UIFieldType.ObjectRef),
        new("FateGuestInfo", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
