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
         new("MultiData", FieldType.Bool),
         new("LanguageData", FieldType.String),
         new("LanguageOverwriteData", FieldType.String),
         new("ContainerData", FieldType.String),

         // ui::component::LanguageOverwrite
         new("Overwrites", FieldType.ObjectArray,
         [
              new("Language", FieldType.String),
              new("Margine", FieldType.CVec4),
              new("FontSize", FieldType.S32),
              new("CharacterSpaching", FieldType.F32),
              new("LineSpaching", FieldType.F32),
              new("Alignment", FieldType.S32),
              new("EnableFS", FieldType.Bool),
              new("EnableCS", FieldType.Bool),
              new("EnableLS", FieldType.Bool),
              new("EnableMG", FieldType.Bool),
              new("EnableAL", FieldType.Bool),
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
