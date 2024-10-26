using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Title;

// ui::component::ControllerSaveCaution
public class ControllerSaveCaution // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("MenuDialog", UIFieldType.ObjectRef),
        new("CautionText", UIFieldType.ObjectRef),
        new("SaveIcon", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
