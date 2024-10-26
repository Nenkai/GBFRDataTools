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
        new("RazielRoots", UIFieldType.ObjectRefVector),
        new("AmbrosiaRoots", UIFieldType.ObjectRefVector),
        new("AmbrosiaEmptys", UIFieldType.ObjectRefVector),
        new("LocalizeEmptys", UIFieldType.ObjectRefVector),
        new("MspGets", UIFieldType.ObjectRefVector),
        new("MaxMsp", UIFieldType.ObjectRef),
        new("OverMsp", UIFieldType.ObjectRef),
        new("PrevText", UIFieldType.ObjectRef),
        new("CompareText", UIFieldType.ObjectRef),
        new("GetMspText", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
