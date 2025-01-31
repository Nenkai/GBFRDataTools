using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemChallengeMissionProgress
public class ItemChallengeMissionProgress // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Names", UIFieldType.ObjectRefVector),
         new("NowCounts", UIFieldType.ObjectRefVector),
         new("TargetCounts", UIFieldType.ObjectRefVector),
         new("MaterialInfo", UIFieldType.ObjectRef),
         new("Icons", UIFieldType.ObjectRefVector),
         new("CompleteIcon", UIFieldType.ObjectRef),
         new("ClearTexts", UIFieldType.ObjectRefVector),
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
