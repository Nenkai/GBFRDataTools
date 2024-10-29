using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerGemMixImportantConfirm
public class ControllerGemMixImportantConfirm // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("MenuCheck", UIFieldType.ObjectRef),
        new("MenuDialog", UIFieldType.ObjectRef),
        new("WarningText", UIFieldType.ObjectRef),
        new("ErrorChoiceText", UIFieldType.ObjectRef),
        new("Gems", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
