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
         new("MultiData", UIFieldType.Bool),
         new("LanguageData", UIFieldType.String),
         new("LanguageOverwriteData", UIFieldType.String),
         new("ContainerData", UIFieldType.StringVector),

         // ui::component::LanguageOverwrite
         new("Overwrites", UIFieldType.ObjectArray,
         [
              new("Language", UIFieldType.String),
              new("EnableFS", UIFieldType.Bool),
              new("FontSize", UIFieldType.S32),
              new("EnableCS", UIFieldType.Bool),
              new("CharacterSpaching", UIFieldType.F32),
              new("EnableLS", UIFieldType.Bool),
              new("LineSpaching", UIFieldType.F32),
              new("EnableMG", UIFieldType.Bool),
              new("Margine", UIFieldType.CVec4),
              new("EnableAL", UIFieldType.Bool),
              new("Alignment", UIFieldType.S32),
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
