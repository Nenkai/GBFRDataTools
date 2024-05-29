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
         new("ButtonGuideType", FieldType.String),
         new("Dark", FieldType.Bool),
         new("Buttons", FieldType.ObjectRefVector),
         new("Button2S", FieldType.ObjectRefVector),
         new("Texts", FieldType.ObjectRefVector),
         // TODO: Shortcuts
         new("SlashRoot", FieldType.ObjectRef),
         new("SlashShadow", FieldType.ObjectRef),
         new("Button2Root", FieldType.ObjectRef),
         new("ItemButton", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
