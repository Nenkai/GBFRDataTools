using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::Shortcut
public class Shortcut // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("ButtonTypes", FieldType.StringVector),
         new UIPropertyTypeDef("ItemButton", FieldType.ObjectRef),
         new UIPropertyTypeDef("Button", FieldType.ObjectRef),
         new UIPropertyTypeDef("ButtonType", FieldType.S32),
         new UIPropertyTypeDef("Logic", FieldType.S32),
         new UIPropertyTypeDef("Push", FieldType.Bool),
         new UIPropertyTypeDef("Always", FieldType.Bool),
         new UIPropertyTypeDef("Repeat", FieldType.Bool),
         new UIPropertyTypeDef("Inverse", FieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
