using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Controllers;

// ui::component::ControllerGeenDetail
public class ControllerGeenDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("Geen", FieldType.ObjectRef),
        new UIPropertyTypeDef("PersonalInfo", FieldType.ObjectRef),
        new UIPropertyTypeDef("Charas", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Visibles", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Hides", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
