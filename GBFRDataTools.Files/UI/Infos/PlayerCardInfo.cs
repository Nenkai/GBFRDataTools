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
        new("NameType", UIFieldType.S32),
        new("CharaType", UIFieldType.S32),
        new("Sets", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("OnlineIDs", UIFieldType.ObjectRefVector),
        new(0xC66A07D4, UIFieldType.S8),
        new("CharaIcons", UIFieldType.ObjectRefVector),
        new("EmptyCharaIcons", UIFieldType.ObjectRefVector),
        new("NoNameDispID", UIFieldType.Bool),
        new("UpdateIcon", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
