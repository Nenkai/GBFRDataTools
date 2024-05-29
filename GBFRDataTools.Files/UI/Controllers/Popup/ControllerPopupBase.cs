using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Popup;

// ui::component::ControllerPopupBase
public class ControllerPopupBase // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [

    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        return list;
    }
}
