using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.EndCredit;

// ui::component::ControllerStaffLogo
public class ControllerStaffLogo // : ControllerStaffBase
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Colums", FieldType.ObjectRefVector),
        new("TwoLogos", FieldType.ObjectRefVector),
        new("ThreeLogos", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerStaffBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
