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
        new(0x1600F7A7, FieldType.ObjectRef),
        new("InfoText", FieldType.ObjectRef),
        new("MenuDialog", FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new("WarningObj", FieldType.ObjectRef),
        new(0x86670091, FieldType.ObjectRef),
        new(0xC200E94A, FieldType.ObjectRef),
        new("ListControls", FieldType.ObjectRefVector),
        new(0xEA2AE0F2, FieldType.ObjectRef),
        new(0xFF831FCE, FieldType.ObjectRef)
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
