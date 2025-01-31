using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestEnemyList
public class ItemQuestEnemyList // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("CharaIconObjs", UIFieldType.ObjectRefVector),
         new("CharaIcons", UIFieldType.ObjectRefVector),
         new(0xBF7AAF, UIFieldType.ObjectRefVector),
         new("Name", UIFieldType.ObjectRef),
         new("Element", UIFieldType.ObjectRef),
         new("BossIconObj", UIFieldType.ObjectRef),
         new("CharIconsObj", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
