using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemRewardGoodjob
public class ItemRewardGoodjob // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Anim", UIFieldType.ObjectRef),
        new("Text", UIFieldType.ObjectRef),
        new("Reward", UIFieldType.ObjectRef),
        new("GoodEmpty", UIFieldType.ObjectRef),
        new("GoodEmptyText", UIFieldType.ObjectRef),
        new("GoodEmptyTextFrame", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
