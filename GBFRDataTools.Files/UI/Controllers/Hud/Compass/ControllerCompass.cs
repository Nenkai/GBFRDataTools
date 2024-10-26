using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.Compass;

// ui::component::ControllerCompass
public class ControllerCompass // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("ObjIndicators", UIFieldType.ObjectRefVector),
        new("IconFacility", UIFieldType.ObjectRefVector),
        new("IconDestination", UIFieldType.ObjectRefVector),
        new("IconSideQuest", UIFieldType.ObjectRefVector),
        new("CompassWidthHalf", UIFieldType.F32),
        new("DistanceLimitFacility", UIFieldType.F32Vector),
        new("DistanceLimitSideQuest", UIFieldType.F32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
