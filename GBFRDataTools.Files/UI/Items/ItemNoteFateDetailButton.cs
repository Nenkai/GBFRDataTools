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
         new("Animator", FieldType.ObjectRef),
         new("ItemOwnerObject", FieldType.ObjectRef),
         new("NewIconImage", FieldType.ObjectRef),
         new("LockIconImage", FieldType.ObjectRef),
         new("FateEpIconImage", FieldType.ObjectRef),
         new("TextList", FieldType.ObjectRefVector),
         new("DisableCanvas", FieldType.ObjectRef),
         new("FixOwnerObject", FieldType.ObjectRef),
         new("CursorOwnerObject", FieldType.ObjectRef),
         new("FateEpisodeInfo", FieldType.ObjectRef),
         new("HeaderTexts", FieldType.ObjectRefVector),
         new("EpisodeNumberText", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
