using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuOnlinePlayerListDetail
public class MenuOnlinePlayerListDetail // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("CharaInfo", FieldType.ObjectRef),
        new("PlayerCardInfo", FieldType.ObjectRef),
        new("SwichNameTextList", FieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
