using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.PlParameter;

// ui::component::ControllerPlParameterGuest
public class ControllerPlParameterGuest // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Name", UIFieldType.ObjectRef),
        new("Root", UIFieldType.ObjectRef),
        new("CharaFaceIcon", UIFieldType.ObjectRef),
        new("CharaFaceGray", UIFieldType.ObjectRef),
        new("CharaFaceMask", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
