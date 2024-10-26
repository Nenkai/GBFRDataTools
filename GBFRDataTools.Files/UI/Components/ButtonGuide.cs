using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonGuide
public class ButtonGuide // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("ButtonGuideType", UIFieldType.String),
         new("Dark", UIFieldType.Bool),
         new("Buttons", UIFieldType.ObjectRefVector),
         new("Button2S", UIFieldType.ObjectRefVector),
         new("Texts", UIFieldType.ObjectRefVector),
         // TODO: Shortcuts
         new("SlashRoot", UIFieldType.ObjectRef),
         new("SlashShadow", UIFieldType.ObjectRef),
         new("Button2Root", UIFieldType.ObjectRef),
         new("ItemButton", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
