using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerPendulumDetail
public class ControllerPendulumDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Pendulum", FieldType.ObjectRef),
        new("Visibles", FieldType.ObjectRefVector),
        new("Hides", FieldType.ObjectRefVector),
        new("Soldout", FieldType.ObjectRef),
        new("SoldoutCanvas", FieldType.ObjectRef),
        new("AnimationEvent", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
