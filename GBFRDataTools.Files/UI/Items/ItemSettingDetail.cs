using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemSettingDetail
public class ItemSettingDetail // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0x2110046C, UIFieldType.ObjectRefVector),
        new("Title", UIFieldType.ObjectRef),
        new(0x3EFB6DBA, UIFieldType.ObjectRef),
        new("CharaIcon", UIFieldType.ObjectRef),
        new("Line", UIFieldType.ObjectRef),
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
