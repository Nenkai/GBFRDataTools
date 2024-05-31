using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerMission
public class ControllerMission // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Type", FieldType.S32),
        new("Root", FieldType.ObjectRef),
        new("Title", FieldType.ObjectRef),
        new("Contents", FieldType.ObjectRefVector),
        new("Bg", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
