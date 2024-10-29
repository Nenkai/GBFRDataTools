using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.PlParameter;

// ui::component::ControllerPlParameter01
public class ControllerPlParameter01 // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("Name", UIFieldType.ObjectRef),
        new("Type", UIFieldType.S32),
        new("OnlineName", UIFieldType.ObjectRef),
        new("Level", UIFieldType.ObjectRef),
        new("LevelUp", UIFieldType.ObjectRef),
        new("CharaInfo", UIFieldType.ObjectRef),
        new("CharaFaceIcon", UIFieldType.ObjectRef),
        new("CharaFaceGray", UIFieldType.ObjectRef),
        new("CharaFaceMask", UIFieldType.ObjectRef),
        new("NowHp", UIFieldType.ObjectRef),
        new("NowHpRed", UIFieldType.ObjectRef),
        new("MaxHp", UIFieldType.ObjectRef),
        new("MaxHpRed", UIFieldType.ObjectRef),
        new("HpStatusMask", UIFieldType.ObjectRef),
        new("HpSlash", UIFieldType.ObjectRef),
        new("HpSlashRed", UIFieldType.ObjectRef),
        new("HpGauge01", UIFieldType.ObjectRef),
        new("HpGauge02", UIFieldType.ObjectRef),
        new("HpGaugeMask", UIFieldType.ObjectRef),
        new("HpGaugeEff01", UIFieldType.ObjectRef),
        new("HpGaugeEff02", UIFieldType.ObjectRef),
        new("HpDown01", UIFieldType.ObjectRef),
        new("HpDown02", UIFieldType.ObjectRef),
        new("HpGaugeMax", UIFieldType.ObjectRef),
        new("BarrierHp", UIFieldType.ObjectRef),
        new("SpIcon", UIFieldType.ObjectRef),
        new("SpGaugeMask", UIFieldType.ObjectRef),
        new("NowSp", UIFieldType.ObjectRef),
        new("IconStatusSet", UIFieldType.ObjectRef),
        new("LeaderIconObject", UIFieldType.ObjectRef),
        new("StatusDamage", UIFieldType.ObjectRef),
        new("StatusHeal", UIFieldType.ObjectRef),
        new("LtLoop", UIFieldType.ObjectRef),
        new(0x642AF919, UIFieldType.ObjectRef), // Level sync icon, not sure of hash.
        new(0xD8EF9117, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
