using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestDetailBahaChara
public class ItemQuestDetailBahaChara // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("ReleaseObjs", UIFieldType.ObjectRefVector),
         new("NoReleaseObj", UIFieldType.ObjectRef),
         new("CharaIcon", UIFieldType.ObjectRef),
         new("CharaImage", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
