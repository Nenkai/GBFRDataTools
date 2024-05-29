using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerInventoryInfo
public class ControllerInventoryInfo // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Info", FieldType.ObjectRef),
        new("Plates", FieldType.ObjectRefVector),
        new("Empty", FieldType.ObjectRef),
        new("EmptyText", FieldType.ObjectRef),
        new("Y", FieldType.ObjectRef),
        new("SkillGuide", FieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
