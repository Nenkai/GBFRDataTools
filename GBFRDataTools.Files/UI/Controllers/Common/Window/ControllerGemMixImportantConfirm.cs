using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerGemMixImportantConfirm
public class ControllerGemMixImportantConfirm // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x33910708, FieldType.ObjectRef),
        new("MenuDialog", FieldType.ObjectRef),
        new("WarningText", FieldType.ObjectRef),
        new(0x9CB16264, FieldType.ObjectRef),
        new(0xF7C78B5C, FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
