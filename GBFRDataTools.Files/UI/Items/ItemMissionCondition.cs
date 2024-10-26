using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemMissionCondition
public class ItemMissionCondition // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Icon", UIFieldType.ObjectRef),
         new("Title", UIFieldType.ObjectRef),
         new("NowCount", UIFieldType.ObjectRef),
         new("TargetCount", UIFieldType.ObjectRef),
         new("SafeTime", UIFieldType.ObjectRefVector),
         new("WarnTime", UIFieldType.ObjectRefVector),
         new("AddTime", UIFieldType.ObjectRefVector),
         new("Animator", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
