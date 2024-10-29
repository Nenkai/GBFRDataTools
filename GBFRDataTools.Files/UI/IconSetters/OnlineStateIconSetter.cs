using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.IconSetters;

// ui::component::OnlineStateIconSetter
public class OnlineStateIconSetter // : IconSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Type", UIFieldType.S32),
        new("StateDispIcon", UIFieldType.Bool),
        new("StateSettingIcon", UIFieldType.Bool),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(IconSetter.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
