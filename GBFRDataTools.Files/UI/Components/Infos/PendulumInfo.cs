using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::PendulumInfo
public class PendulumInfo : Component
{
    public List<UIObjectRef> Sets { get; set; }
    public List<UIObjectRef> Empties { get; set; }
    public List<UIObjectRef> SetImages { get; set; }
    public List<UIObjectRef> Names { get; set; }
    public List<UIObjectRef> Icons { get; set; }
    public List<UIObjectRef> Skills { get; set; }
    public List<UIObjectRef> EmptyTexts { get; set; }
    public UIObjectRef Icon { get; set; }
    public UIObjectRef SkillList { get; set; }
    public UIObjectRef Protection { get; set; }
    public UIObjectRef ProtectionFav { get; set; }
    public UIObjectRef Ticket { get; set; }
    public UIObjectRef RupiInfo { get; set; }
    public UIObjectRef UpdateIcon { get; set; }
    public UIObjectRef Rarity { get; set; }
    public UIObjectRef BgImageSetter { get; set; }
}
