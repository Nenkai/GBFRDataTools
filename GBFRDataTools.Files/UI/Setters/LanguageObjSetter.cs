using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::LanguageObjSetter
public class LanguageObjSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
         new ("Data", UIFieldType.ObjectArray, 
         [
             // ui::component::LanguageParamSet
             new("Params", UIFieldType.ObjectArray, 
             [
                 // ui::component::LanguageParam
                 new("Language", UIFieldType.String),
                 new("Actvalue", UIFieldType.Bool),
             ]),
             new("Type", UIFieldType.S32),
             new("Value", UIFieldType.S32),
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
