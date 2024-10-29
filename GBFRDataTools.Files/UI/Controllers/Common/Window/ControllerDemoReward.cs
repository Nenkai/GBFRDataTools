using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerDemoReward
public class ControllerDemoReward // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x1600F7A7, UIFieldType.ObjectRef),
        new("InfoText", UIFieldType.ObjectRef),
        new("MenuDialog", UIFieldType.ObjectRef),
        new("TitleText", UIFieldType.ObjectRef),
        new("WarningObj", UIFieldType.ObjectRef),
        new(0x86670091, UIFieldType.ObjectRef),
        new(0xC200E94A, UIFieldType.ObjectRef),
        new("ListControls", UIFieldType.ObjectRefVector),
        new("MenuReward", UIFieldType.ObjectRef),
        new(0xFF831FCE, UIFieldType.ObjectRef)
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
