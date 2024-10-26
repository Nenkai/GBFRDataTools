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
        new("Info", UIFieldType.ObjectRef),
        new("Plates", UIFieldType.ObjectRefVector),
        new("Empty", UIFieldType.ObjectRef),
        new("EmptyText", UIFieldType.ObjectRef),
        new("Y", UIFieldType.ObjectRef),
        new("SkillGuide", UIFieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
