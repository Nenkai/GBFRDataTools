using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.IconSetters;

// ui::component::ChallengeMissionIconSetter
public class ChallengeMissionIconSetter // IconSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Icon", UIFieldType.ObjectRef),
        new("IconColor", UIFieldType.ObjectRef),
        new("Shadow", UIFieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Properties);
        list.AddRange(IconSetter.GetAllProperties());
        return list;
    }
}
