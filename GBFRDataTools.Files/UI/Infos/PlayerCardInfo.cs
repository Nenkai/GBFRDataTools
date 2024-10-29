using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::PlayerCardInfo
public class PlayerCardInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x84F0A92F, UIFieldType.S32),
        new("NameType", UIFieldType.S32),
        new("Names", UIFieldType.ObjectRefVector),
        new(0xB6676748, UIFieldType.S8),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new("OnlineIDs", UIFieldType.ObjectRefVector),
        new(0xC66A07D4, UIFieldType.S8),
        new(0x7DED4A26, UIFieldType.ObjectRefVector),
        new("CharaIcons", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
