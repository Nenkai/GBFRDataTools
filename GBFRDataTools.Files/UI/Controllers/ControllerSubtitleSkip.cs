using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerSubTitleSkip
public class ControllerSubtitleSkip // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Skip", FieldType.ObjectRef),
        new("ShowSkip", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
