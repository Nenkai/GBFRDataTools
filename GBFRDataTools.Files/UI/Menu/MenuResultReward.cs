using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Menu;

// ui::component::MenuResultReward
public class MenuResultReward // : Menu
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("LineTileList", UIFieldType.ObjectRefVector),
        new("TitleText", UIFieldType.ObjectRef),
        new("TitleLineBG", UIFieldType.ObjectRef),
        new("EmptyTextObject", UIFieldType.ObjectRef),
        new("OwnerObject", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Menu.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
