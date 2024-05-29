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
         new("Icon", FieldType.ObjectRef),
         new("Title", FieldType.ObjectRef),
         new("NowCount", FieldType.ObjectRef),
         new("TargetCount", FieldType.ObjectRef),
         new("SafeTime", FieldType.ObjectRefVector),
         new("WarnTime", FieldType.ObjectRefVector),
         new("AddTime", FieldType.ObjectRefVector),
         new("Animator", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
