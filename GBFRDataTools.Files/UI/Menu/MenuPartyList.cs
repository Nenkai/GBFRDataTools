using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuPartyList
public class MenuPartyList // : MenuCharaList
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(MenuCharaList.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
