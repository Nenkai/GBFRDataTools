using GBFRDataTools.Files.UI.IconSetters;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::CharaIconSetter
public class CharaIconSetter // IconSetter
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new UIPropertyTypeDef("Type", FieldType.S32),
        new UIPropertyTypeDef("Glow", FieldType.Bool),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(IconSetter.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
