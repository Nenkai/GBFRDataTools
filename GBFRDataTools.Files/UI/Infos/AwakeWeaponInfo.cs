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
        new("EffBack", FieldType.ObjectRef),
        new("EffBack02", FieldType.ObjectRef),
        new("BackGlow01WeaponIconSetter", FieldType.ObjectRef),
        new("BackGlow02WeaponIconSetter", FieldType.ObjectRef),
        new("BackGlow01Image", FieldType.ObjectRef),
        new("BackMaskWeaponIconSetter", FieldType.ObjectRef),
        new("EffTop", FieldType.ObjectRef),
        new("MaskEff01", FieldType.ObjectRef),
        new("MaskEff02", FieldType.ObjectRef),
        new("TopGleam01Image", FieldType.ObjectRef),
        new("TopGleam01WeaponIconSetter", FieldType.ObjectRef),
        new("TopMaskWeaponIconSetter", FieldType.ObjectRef),
        new("SpiralGleams", FieldType.ObjectRefVector),
        new("SpiralGleamsColorC2", FieldType.ObjectRefVector),
        new("SpiralParticlesColorC", FieldType.ObjectRefVector),
        new("SpiralParticlesColorD", FieldType.ObjectRefVector),
        new("SpiralMask01", FieldType.ObjectRef),
        new("SpiralMask03", FieldType.ObjectRef),
        new("SpiralEffectImageSetter", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
