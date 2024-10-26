using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.EndCredit;

// ui::component::ControllerStaffMovie
public class ControllerStaffMovie // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Movie", UIFieldType.ObjectRef),
        new("MovieImage", UIFieldType.ObjectRef),
        new("Skip", UIFieldType.ObjectRef),
        new("ShowGuide", UIFieldType.ObjectRef),
        new("GranMovie", UIFieldType.String),
        new("DjeetaMovie", UIFieldType.String),
        new("CommonMovie", UIFieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
