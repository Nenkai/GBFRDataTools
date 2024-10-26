using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemGuideCommand
public class ItemGuideCommand // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Shortcut", UIFieldType.ObjectRef),
        new("Text", UIFieldType.ObjectRef),
        new("TextPush", UIFieldType.ObjectRef),
        new("AbilityLPush", UIFieldType.ObjectRef),
        new("AbilityRPush", UIFieldType.ObjectRef),
        new("Command", UIFieldType.ObjectRef),
        new("CommandPush", UIFieldType.ObjectRef),
        new("CommandCharge", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
