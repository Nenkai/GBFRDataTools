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
        new("Menu", FieldType.ObjectRef),
        new("CurrentEquip", FieldType.ObjectRef),
        new("SelectButton", FieldType.ObjectRef),
        new("R3", FieldType.ObjectRef),
        new("SortText", FieldType.ObjectRef),
        new("Badge", FieldType.ObjectRef),
        new("FilterCount", FieldType.ObjectRef),
        new("EmptyResult", FieldType.ObjectRef),
        new("EmptyText", FieldType.ObjectRef),
        new("Resizes", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
