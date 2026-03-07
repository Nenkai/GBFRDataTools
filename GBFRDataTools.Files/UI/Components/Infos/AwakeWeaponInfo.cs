using GBFRDataTools.Files.UI.Types;

namespace GBFRDataTools.Files.UI.Components.Infos;

// ui::component::AwakeWeaponInfo
public class AwakeWeaponInfo : Component
{
    public UIObjectRef EffBack { get; set; }
    public UIObjectRef EffBack02 { get; set; }
    public UIObjectRef BackGlow01WeaponIconSetter { get; set; }
    public UIObjectRef BackGlow02WeaponIconSetter { get; set; }
    public UIObjectRef BackGlow01Image { get; set; }
    public UIObjectRef BackMaskWeaponIconSetter { get; set; }
    public UIObjectRef EffTop { get; set; }
    public UIObjectRef MaskEff01 { get; set; }
    public UIObjectRef MaskEff02 { get; set; }
    public UIObjectRef TopGleam01Image { get; set; }
    public UIObjectRef TopGleam01WeaponIconSetter { get; set; }
    public UIObjectRef TopMaskWeaponIconSetter { get; set; }
    public List<UIObjectRef> SpiralGleams { get; set; }
    public List<UIObjectRef> SpiralGleamsColorC2 { get; set; }
    public List<UIObjectRef> SpiralParticlesColorC { get; set; }
    public List<UIObjectRef> SpiralParticlesColorD { get; set; }
    public UIObjectRef SpiralMask01 { get; set; }
    public UIObjectRef SpiralMask03 { get; set; }
    public List<UIObjectRef> SpiralEffectImageSetter { get; set; }
}
