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
        new("Sprite", FieldType.Object,
        [
            // ui::SpriteRef
            new("TexturePath", FieldType.String),
            new("SpriteName", FieldType.CyanStringHash),
        ]),
        new("Rate", FieldType.F32),
        new("IsFullscreen", FieldType.Bool)
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
