using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::LanguageSetter
public class LanguageSetter // : Component
{
    
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new UIPropertyTypeDef("MultiData", FieldType.Bool),
         new UIPropertyTypeDef("LanguageData", FieldType.String),
         new UIPropertyTypeDef("LanguageOverwriteData", FieldType.String),
         new UIPropertyTypeDef("ContainerData", FieldType.String),

         // ui::component::LanguageOverwrite
         new UIPropertyTypeDef("Overwrites", FieldType.ObjectArray,
         [
              new UIPropertyTypeDef("Language", FieldType.String),
              new UIPropertyTypeDef("Margine", FieldType.CVec4),
              new UIPropertyTypeDef(0xf7acd4b0, FieldType.S32),
              new UIPropertyTypeDef("CharacterSpaching", FieldType.F32),
              new UIPropertyTypeDef("LineSpaching", FieldType.F32),
              new UIPropertyTypeDef("Alignment", FieldType.S32),
              new UIPropertyTypeDef("EnableFS", FieldType.Bool),
              new UIPropertyTypeDef("EnableCS", FieldType.Bool),
              new UIPropertyTypeDef("EnableLS", FieldType.Bool),
              new UIPropertyTypeDef("EnableMG", FieldType.Bool),
              new UIPropertyTypeDef("EnableAL", FieldType.Bool),
         ]),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
