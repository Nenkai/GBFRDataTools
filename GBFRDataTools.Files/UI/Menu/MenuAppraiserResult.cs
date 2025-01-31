using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuAppraiserResult
public class MenuAppraiserResult // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("ScrollDisps", UIFieldType.ObjectRefVector),
        new("ScrollHides", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
