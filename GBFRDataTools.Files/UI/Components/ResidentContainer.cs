using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ResidentContainer
public class ResidentContainer // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x668138D9, UIFieldType.StringVector),
        new(0x780D445D, UIFieldType.StringVector),
        new(0x91AADF61, UIFieldType.Object,
         [
             // ui::SpriteRef
             new("TexturePath", UIFieldType.String),
             new("SpriteName", UIFieldType.CyanStringHash),
         ]),
        new(0x7EBC4596, UIFieldType.Object,
         [
             // ui::SpriteRef
             new("TexturePath", UIFieldType.String),
             new("SpriteName", UIFieldType.CyanStringHash),
         ]),
        new(0xBA2624B1, UIFieldType.String),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
