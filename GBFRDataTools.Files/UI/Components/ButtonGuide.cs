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
         new UIPropertyTypeDef("ButtonGuideType", FieldType.String),
         new UIPropertyTypeDef("Dark", FieldType.Bool),
         new UIPropertyTypeDef("Buttons", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("Button2S", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("Texts", FieldType.ObjectRefVector),
         // TODO: Shortcuts
         new UIPropertyTypeDef("SlashRoot", FieldType.ObjectRef),
         new UIPropertyTypeDef("SlashShadow", FieldType.ObjectRef),
         new UIPropertyTypeDef("Button2Root", FieldType.ObjectRef),
         new UIPropertyTypeDef("ItemButton", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
