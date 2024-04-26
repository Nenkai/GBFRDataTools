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
         new UIPropertyTypeDef("Pendulum", FieldType.ObjectRef),
        new UIPropertyTypeDef("Visibles", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Hides", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Soldout", FieldType.ObjectRef),
        new UIPropertyTypeDef("SoldoutCanvas", FieldType.ObjectRef),
        new UIPropertyTypeDef("AnimationEvent", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
