using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.ObjectEm;

// ui::component::ControllerCompassIcon
public class ControllerCompassIcon // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", UIFieldType.ObjectRef),
        new("ImgIcon", UIFieldType.ObjectRef),
        new("ImgProgress", UIFieldType.ObjectRef),
        new("ObjDestination", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
