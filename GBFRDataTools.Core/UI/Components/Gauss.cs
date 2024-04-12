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
        new UIPropertyTypeDef("Sprite", FieldType.ObjectRef,
        [
            // ui::SpriteRef
            new UIPropertyTypeDef("TexturePath", FieldType.String),
            new UIPropertyTypeDef("SpriteName", FieldType.CyanStringHash),
        ]),
        new UIPropertyTypeDef("Rate", FieldType.F32),
        new UIPropertyTypeDef("IsFullscreen", FieldType.Bool)
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
