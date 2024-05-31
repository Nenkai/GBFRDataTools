using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerGuessCharaSelectSkin
public class ControllerGuessCharaSelectSkin // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", FieldType.ObjectRef),
        new("CurrentSkinInfo", FieldType.ObjectRef),
        new("LineSeparateList", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
