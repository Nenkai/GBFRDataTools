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
        new(0x84F0A92F, FieldType.S32),
        new(0x8E682DFE, FieldType.S32),
        new("Names", FieldType.ObjectRefVector),
        new(0xB6676748, FieldType.S8),
        new("UpdateIcon", FieldType.ObjectRef),
        new(0xD46085D3, FieldType.ObjectRefVector),
        new(0xC66A07D4, FieldType.S8),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
