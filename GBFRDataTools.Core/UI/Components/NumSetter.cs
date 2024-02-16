using GBFRDataTools.Core.UI.IconSetters;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::NumSetter
public class NumSetter // NumSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Images", FieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(IconSetter.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
