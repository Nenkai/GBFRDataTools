using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerExchangeData
public class ControllerExchangeData // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TitleTexts", UIFieldType.ObjectRefVector),
        new("Resizes", UIFieldType.ObjectRefVector),
        new("Menu", UIFieldType.ObjectRef),
        new("CurrentData", UIFieldType.ObjectRef),
        new("FuncBtn", UIFieldType.ObjectRef),
        new("ResetBtn", UIFieldType.ObjectRef),
        new("ExchangeMode", UIFieldType.S32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
