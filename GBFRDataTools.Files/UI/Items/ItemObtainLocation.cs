using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemObtainLocation
public class ItemObtainLocation // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Timer", UIFieldType.ObjectRefVector),
         new("LocationText", UIFieldType.ObjectRefVector),
         new("ValueText", UIFieldType.ObjectRefVector),
         new("IconImage", UIFieldType.ObjectRef),
         new("TitleText", UIFieldType.ObjectRef),
         new("IconSlash", UIFieldType.ObjectRef),
         new("QuestInfo", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
