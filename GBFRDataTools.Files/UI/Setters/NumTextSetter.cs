
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

namespace GBFRDataTools.Files.UI.Setters;

// ui::component::NumTextSetter
public class NumTextSetter // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Num", UIFieldType.F32),
         new("DigitDecimal", UIFieldType.U32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
