using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::FilterSortInfo
public class FilterSortInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("FilterCount", UIFieldType.ObjectRef),
        new("Badge", UIFieldType.ObjectRef),
        new("SortText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
