using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SubMenuButton
public class SubMenuButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("ItemName", UIFieldType.ObjectRef),
        new("OpenSubmenuShortcut", UIFieldType.ObjectRef),
        new("SoundContainer", UIFieldType.ObjectRef),
        new("Animator", UIFieldType.ObjectRef),
        new("ChildButton", UIFieldType.ObjectRef),
        new("OptionLRCursors", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
