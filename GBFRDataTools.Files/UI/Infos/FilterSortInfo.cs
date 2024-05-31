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
        new("FilterCount", FieldType.ObjectRef),
        new("Badge", FieldType.ObjectRef),
        new("SortText", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
