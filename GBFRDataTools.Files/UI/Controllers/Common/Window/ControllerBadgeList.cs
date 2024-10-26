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
        new("SrcBadgeInfo", UIFieldType.ObjectRef),
        new("BadgeList", UIFieldType.ObjectRef),
        new("ImageButtonSetter", UIFieldType.ObjectRef),
        new("SortShortCutBtn", UIFieldType.ObjectRef),
        new("InitShortCutBtn", UIFieldType.ObjectRef),
        new("FilterSortInfo", UIFieldType.ObjectRef),
        new("EmptyDrawObjects", UIFieldType.ObjectRefVector),
        new("AdjustResizeObjs", UIFieldType.ObjectRefVector),
        new("InitButtonGuideOwners", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
