using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::MspUsedItemInfo
public class MspUsedItemInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("RazielRoots", FieldType.ObjectRefVector),
        new("AmbrosiaRoots", FieldType.ObjectRefVector),
        new("AmbrosiaEmptys", FieldType.ObjectRefVector),
        new("LocalizeEmptys", FieldType.ObjectRefVector),
        new("MspGets", FieldType.ObjectRefVector),
        new("MaxMsp", FieldType.ObjectRef),
        new("OverMsp", FieldType.ObjectRef),
        new("PrevText", FieldType.ObjectRef),
        new("CompareText", FieldType.ObjectRef),
        new("GetMspText", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
