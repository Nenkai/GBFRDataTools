using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuGeenList
public class MenuGeenList // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Mode", FieldType.S32),
        new(0x1CA3608F, FieldType.S32)
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
