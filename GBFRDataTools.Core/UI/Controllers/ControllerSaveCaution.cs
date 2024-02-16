using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Controllers;

// ui::component::ControllerSaveCaution
public class ControllerSaveCaution // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef("MenuDialog", FieldType.ObjectRef),
        new UIPropertyTypeDef("CautionText", FieldType.ObjectRef),
        new UIPropertyTypeDef("SaveIcon", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
