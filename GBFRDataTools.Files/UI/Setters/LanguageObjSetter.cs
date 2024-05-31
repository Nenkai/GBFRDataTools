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
         new ("Data", FieldType.ObjectArray, 
         [
             // ui::component::LanguageParamSet
             new("Params", FieldType.ObjectArray, 
             [
                 // ui::component::LanguageParam
                 new("Language", FieldType.String),
                 new("Actvalue", FieldType.Bool),
             ]),
             new("Type", FieldType.S32),
             new("Value", FieldType.S32),
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
