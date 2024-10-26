using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Gauss
public class Gauss // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sprite", UIFieldType.Object,
        [
            // ui::SpriteRef
            new("TexturePath", UIFieldType.String),
            new("SpriteName", UIFieldType.CyanStringHash),
        ]),
        new("Rate", UIFieldType.F32),
        new("IsFullscreen", UIFieldType.Bool)
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
