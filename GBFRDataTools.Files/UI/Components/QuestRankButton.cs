using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::InputTextButton
public class QuestRankButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("ItemName", UIFieldType.ObjectRef),
        new("OpenShortcut", UIFieldType.ObjectRef),
        new("SoundContainer", UIFieldType.ObjectRef),
        new("Button", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
