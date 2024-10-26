using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemSteamLobbyTarget
public class ItemSteamLobbyTarget // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Sets", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
        new("Image", UIFieldType.ObjectRef),
        new(0x7747336C, UIFieldType.ObjectRef),
        new(0x87B25F6C, UIFieldType.ObjectRef),
        new("Names", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
