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
        new UIPropertyTypeDef("Name", FieldType.ObjectRef),
        new UIPropertyTypeDef("Level", FieldType.ObjectRef),
        new UIPropertyTypeDef("HpValue", FieldType.ObjectRef),
        new UIPropertyTypeDef("HpGauge", FieldType.ObjectRef),
        new UIPropertyTypeDef("HpStatusGauge", FieldType.ObjectRef),
        new UIPropertyTypeDef("HpStatusDamageGauge", FieldType.ObjectRef),
        new UIPropertyTypeDef("ModeGauge", FieldType.ObjectRef),
        new UIPropertyTypeDef("IconStatusSet", FieldType.ObjectRef),
        new UIPropertyTypeDef("GaugeEffectObj", FieldType.ObjectRef),
        new UIPropertyTypeDef("Root", FieldType.ObjectRef),
        new UIPropertyTypeDef("GaugeEffectPosXMin", FieldType.F32),
        new UIPropertyTypeDef("GaugeEffectPosXMax", FieldType.F32),
        new UIPropertyTypeDef("Element", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
