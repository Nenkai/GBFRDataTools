using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerSubListGem
public class ControllerSubListGem // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Menu", UIFieldType.ObjectRef),
        new("CurrentEquip", UIFieldType.ObjectRef),
        new("SelectButton", UIFieldType.ObjectRef),
        new("R3", UIFieldType.ObjectRef),
        new("SortText", UIFieldType.ObjectRef),
        new("Badge", UIFieldType.ObjectRef),
        new("FilterCount", UIFieldType.ObjectRef),
        new("EmptyResult", UIFieldType.ObjectRef),
        new("EmptyText", UIFieldType.ObjectRef),
        new("Resizes", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
