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
        new("Animator", FieldType.ObjectRef),
        new("MenuObjsRU", FieldType.ObjectRefVector),
        new("MenuObjs01", FieldType.ObjectRefVector),
        new("MenuObjs02", FieldType.ObjectRefVector),
        new("MenuObjs03", FieldType.ObjectRefVector),
        new("MenuObjs04", FieldType.ObjectRefVector),
        new("MenuObjs05", FieldType.ObjectRefVector),
        new("MenuObjs06", FieldType.ObjectRefVector),
        new("MenuObjs07", FieldType.ObjectRefVector),
        new("MenuObjs08", FieldType.ObjectRefVector),
        new("MenuObjs09", FieldType.ObjectRefVector),
        new("MenuObjs10", FieldType.ObjectRefVector),
        new("MenuObjs11", FieldType.ObjectRefVector),
        new("SelectMenusRU", FieldType.ObjectRefVector),
        new("SelectMenus01", FieldType.ObjectRefVector),
        new("SelectMenus02", FieldType.ObjectRefVector),
        new("SelectMenus03", FieldType.ObjectRefVector),
        new("SelectMenus04", FieldType.ObjectRefVector),
        new("SelectMenus05", FieldType.ObjectRefVector),
        new("SelectMenus06", FieldType.ObjectRefVector),
        new("SelectMenus07", FieldType.ObjectRefVector),
        new("SelectMenus08", FieldType.ObjectRefVector),
        new("SelectMenus09", FieldType.ObjectRefVector),
        new("SelectMenus10", FieldType.ObjectRefVector),
        new("SelectMenus11", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
