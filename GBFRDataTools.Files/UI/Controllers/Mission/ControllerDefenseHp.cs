using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Mission;

// ui::component::ControllerDefenseHp
public class ControllerDefenseHp // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Root", FieldType.ObjectRef),
        new("Icon", FieldType.ObjectRef),
        new("Name", FieldType.ObjectRef),
        new("HpGaugeMask", FieldType.ObjectRef),
        new("HpLiningMask", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
