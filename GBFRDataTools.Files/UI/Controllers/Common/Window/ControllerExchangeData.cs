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
        new("TitleTexts", FieldType.ObjectRefVector),
        new("Resizes", FieldType.ObjectRefVector),
        new("Menu", FieldType.ObjectRef),
        new("CurrentData", FieldType.ObjectRef),
        new("FuncBtn", FieldType.ObjectRef),
        new("ResetBtn", FieldType.ObjectRef),
        new("ExchangeMode", FieldType.S32),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
