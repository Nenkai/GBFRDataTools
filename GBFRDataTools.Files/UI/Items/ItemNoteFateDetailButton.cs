using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemNoteFateDetailButton
public class ItemNoteFateDetailButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Animator", UIFieldType.ObjectRef),
         new("ItemOwnerObject", UIFieldType.ObjectRef),
         new("NewIconImage", UIFieldType.ObjectRef),
         new("LockIconImage", UIFieldType.ObjectRef),
         new("FateEpIconImage", UIFieldType.ObjectRef),
         new("TextList", UIFieldType.ObjectRefVector),
         new("DisableCanvas", UIFieldType.ObjectRef),
         new("FixOwnerObject", UIFieldType.ObjectRef),
         new("CursorOwnerObject", UIFieldType.ObjectRef),
         new("FateEpisodeInfo", UIFieldType.ObjectRef),
         new("HeaderTexts", UIFieldType.ObjectRefVector),
         new("EpisodeNumberText", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
