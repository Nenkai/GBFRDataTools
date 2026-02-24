using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Items;

// ui::component::ItemQuestDetailBahaWeapon
public class ItemQuestDetailBahaWeapon : Component
{
    public List<UIObjectRef> WeaponSkills { get; set; }
    public List<UIObjectRef> _4DDEA1F2 { get; set; }
    public List<UIObjectRef> CharaIcon { get; set; }
    public UIObjectRef Animator { get; set; }
    public UIObjectRef WeaponRootObj { get; set; }
    public UIObjectRef WeaponTitle { get; set; }
    public UIObjectRef WeaponLevel { get; set; }
    public UIObjectRef WeaponLimit { get; set; }
    public UIObjectRef HasAllWeaponObj { get; set; }
    public UIObjectRef ChangeSkillDispMode { get; set; }
}
