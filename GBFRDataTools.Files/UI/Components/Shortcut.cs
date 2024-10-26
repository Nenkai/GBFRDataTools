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
         new("Logic", UIFieldType.S32),
         new("ButtonType", UIFieldType.S32),
         new("Push", UIFieldType.Bool),
         new("Always", UIFieldType.Bool),
         new("Repeat", UIFieldType.Bool),
         new("Inverse", UIFieldType.Bool),
         new("ItemButton", UIFieldType.ObjectRef),
         new("Button", UIFieldType.ObjectRef),
         new("ButtonTypes", UIFieldType.S32Vector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
