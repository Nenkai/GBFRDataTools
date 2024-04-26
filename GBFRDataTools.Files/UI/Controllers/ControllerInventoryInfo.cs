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
         new UIPropertyTypeDef("Info", FieldType.ObjectRef),
        new UIPropertyTypeDef("Plates", FieldType.ObjectRefVector),
        new UIPropertyTypeDef("Empty", FieldType.ObjectRef),
        new UIPropertyTypeDef("EmptyText", FieldType.ObjectRef),
        new UIPropertyTypeDef("Y", FieldType.ObjectRef),
        new UIPropertyTypeDef("SkillGuide", FieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
