using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerAbilityDetail
public class ControllerAbilityDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("AbilityInfo", FieldType.ObjectRef),
        new("StatusNoneText", FieldType.ObjectRef),
        new("CloseDetail", FieldType.ObjectRef),
        new("Cancel", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
