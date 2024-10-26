using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.EmParameter;

// ui::component::ControllerEmParam
public class ControllerEmParam // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("Name", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Level", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("HpValue", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("HpGauge", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("HpStatusGauge", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("HpStatusDamageGauge", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("ModeGauge", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("IconStatusSet", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("GaugeEffectObj", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("Root", UIFieldType.ObjectRef),
        new UIPropertyTypeDef("GaugeEffectPosXMin", UIFieldType.F32),
        new UIPropertyTypeDef("GaugeEffectPosXMax", UIFieldType.F32),
        new UIPropertyTypeDef("Element", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
