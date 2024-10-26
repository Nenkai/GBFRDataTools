using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuSettingSubWindow
public class MenuSettingSubWindow // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("SelectItemInfo", UIFieldType.ObjectRef),
        new("AssistIcons", UIFieldType.ObjectRefVector),
        new("SuperAssistIcons", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
