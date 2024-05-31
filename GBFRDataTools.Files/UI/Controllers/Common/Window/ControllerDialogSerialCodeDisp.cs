using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerDialogSerialCodeDisp
public class ControllerDialogSerialCodeDisp // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x1A075914, FieldType.ObjectRef),
        new(0x648723D4, FieldType.ObjectRef),
        new(0x65DE7C0F, FieldType.ObjectRef),
        new(0x68602E8F, FieldType.ObjectRef),
        new("TitleText", FieldType.ObjectRef),
        new(0x96312960, FieldType.ObjectRef),
        new(0x985B4353, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
