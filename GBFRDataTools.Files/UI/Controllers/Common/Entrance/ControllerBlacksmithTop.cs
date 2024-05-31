using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Entrance;

// ui::component::ControllerBlacksmithTop
public class ControllerBlacksmithTop // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", FieldType.ObjectRef),
        new("MenuSub", FieldType.ObjectRef),
        new("Bg", FieldType.ObjectRef),
        new("SetupEntrance", FieldType.ObjectRef),
        new("TradeDetail", FieldType.ObjectRef),
        new("Favorite", FieldType.ObjectRef),
        new("FavoriteList", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
