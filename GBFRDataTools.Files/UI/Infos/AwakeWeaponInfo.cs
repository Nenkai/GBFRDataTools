using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::AwakeWeaponInfo
public class AwakeWeaponInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("EffBack", UIFieldType.ObjectRef),
        new("EffBack02", UIFieldType.ObjectRef),
        new("BackGlow01WeaponIconSetter", UIFieldType.ObjectRef),
        new("BackGlow02WeaponIconSetter", UIFieldType.ObjectRef),
        new("BackGlow01Image", UIFieldType.ObjectRef),
        new("BackMaskWeaponIconSetter", UIFieldType.ObjectRef),
        new("EffTop", UIFieldType.ObjectRef),
        new("MaskEff01", UIFieldType.ObjectRef),
        new("MaskEff02", UIFieldType.ObjectRef),
        new("TopGleam01Image", UIFieldType.ObjectRef),
        new("TopGleam01WeaponIconSetter", UIFieldType.ObjectRef),
        new("TopMaskWeaponIconSetter", UIFieldType.ObjectRef),
        new("SpiralGleams", UIFieldType.ObjectRefVector),
        new("SpiralGleamsColorC2", UIFieldType.ObjectRefVector),
        new("SpiralParticlesColorC", UIFieldType.ObjectRefVector),
        new("SpiralParticlesColorD", UIFieldType.ObjectRefVector),
        new("SpiralMask01", UIFieldType.ObjectRef),
        new("SpiralMask03", UIFieldType.ObjectRef),
        new("SpiralEffectImageSetter", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
