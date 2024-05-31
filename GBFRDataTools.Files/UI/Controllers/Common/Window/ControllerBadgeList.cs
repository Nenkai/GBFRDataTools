using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerBadgeList
public class ControllerBadgeList // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("SrcBadgeInfo", FieldType.ObjectRef),
        new("BadgeList", FieldType.ObjectRef),
        new("ImageButtonSetter", FieldType.ObjectRef),
        new("SortShortCutBtn", FieldType.ObjectRef),
        new("InitShortCutBtn", FieldType.ObjectRef),
        new("FilterSortInfo", FieldType.ObjectRef),
        new("EmptyDrawObjects", FieldType.ObjectRefVector),
        new("AdjustResizeObjs", FieldType.ObjectRefVector),
        new("InitButtonGuideOwners", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
