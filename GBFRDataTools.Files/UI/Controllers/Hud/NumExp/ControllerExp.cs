using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.NumExp;

// ui::component::ControllerExp
public class ControllerExp // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("Exp", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
