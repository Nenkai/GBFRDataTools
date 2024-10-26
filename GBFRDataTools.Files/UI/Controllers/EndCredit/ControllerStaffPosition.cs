using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.EndCredit;

// ui::component::ControllerStaffPosition
public class ControllerStaffPosition // : ControllerStaffBase
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Loc", UIFieldType.ObjectRef),
        new("PositionName", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerStaffBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
