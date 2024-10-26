using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SetupEntrance
public class SetupEntrance // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Animator", UIFieldType.ObjectRef),
        new("MenuObjsRU", UIFieldType.ObjectRefVector),
        new("MenuObjs01", UIFieldType.ObjectRefVector),
        new("MenuObjs02", UIFieldType.ObjectRefVector),
        new("MenuObjs03", UIFieldType.ObjectRefVector),
        new("MenuObjs04", UIFieldType.ObjectRefVector),
        new("MenuObjs05", UIFieldType.ObjectRefVector),
        new("MenuObjs06", UIFieldType.ObjectRefVector),
        new("MenuObjs07", UIFieldType.ObjectRefVector),
        new("MenuObjs08", UIFieldType.ObjectRefVector),
        new("MenuObjs09", UIFieldType.ObjectRefVector),
        new("MenuObjs10", UIFieldType.ObjectRefVector),
        new("MenuObjs11", UIFieldType.ObjectRefVector),
        new("SelectMenusRU", UIFieldType.ObjectRefVector),
        new("SelectMenus01", UIFieldType.ObjectRefVector),
        new("SelectMenus02", UIFieldType.ObjectRefVector),
        new("SelectMenus03", UIFieldType.ObjectRefVector),
        new("SelectMenus04", UIFieldType.ObjectRefVector),
        new("SelectMenus05", UIFieldType.ObjectRefVector),
        new("SelectMenus06", UIFieldType.ObjectRefVector),
        new("SelectMenus07", UIFieldType.ObjectRefVector),
        new("SelectMenus08", UIFieldType.ObjectRefVector),
        new("SelectMenus09", UIFieldType.ObjectRefVector),
        new("SelectMenus10", UIFieldType.ObjectRefVector),
        new("SelectMenus11", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
