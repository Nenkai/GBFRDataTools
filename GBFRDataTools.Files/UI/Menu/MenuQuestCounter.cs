using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuQuestCounter
public class MenuQuestCounter // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new(0xB1B99B4A, UIFieldType.ObjectRef),
        new(0xD4B4A268, UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
