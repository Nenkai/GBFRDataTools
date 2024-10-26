using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.WinCut;

// ui::component::ControllerWinCutLog
public class ControllerWinCutLog // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Items", UIFieldType.ObjectRefVector),
        new("ScrollBar", UIFieldType.ObjectRef),
        new("ScrollTime", UIFieldType.F32),
        new("ScrollMode", UIFieldType.S32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
