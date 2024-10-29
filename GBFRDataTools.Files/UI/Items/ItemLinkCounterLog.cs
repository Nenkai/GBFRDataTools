using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemLinkCounterLog
public class ItemLinkCounterLog // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Root", UIFieldType.ObjectRef),
         new("Animator", UIFieldType.ObjectRef),
         new("CharaInfo", UIFieldType.ObjectRef),
         new("TextAction", UIFieldType.ObjectRef),
         new("TextNum", UIFieldType.ObjectRef),
         new("TextPt", UIFieldType.ObjectRef),
         new("MiniCharaIcon", UIFieldType.ObjectRef),
         new("SpArtsIcon", UIFieldType.ObjectRef),
         new("ManualMat", UIFieldType.ObjectRef),
         new("PartyMat", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
