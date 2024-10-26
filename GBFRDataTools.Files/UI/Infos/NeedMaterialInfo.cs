using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::NeedMaterialInfo
public class NeedMaterialInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Icon", UIFieldType.ObjectRef),
        new("Name", UIFieldType.ObjectRef),
        new("Value", UIFieldType.ObjectRef),
        new("Need", UIFieldType.ObjectRef),
        new("NewValue", UIFieldType.ObjectRef),
        new("ExplainText", UIFieldType.ObjectRef),
        new("CanvasGroup", UIFieldType.ObjectRef),
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("Hides", UIFieldType.ObjectRefVector),
        new("SetImages", UIFieldType.ObjectRefVector),
        new("Icons", UIFieldType.ObjectRefVector),
        new("Lacks", UIFieldType.ObjectRefVector),
        new("FavLacks", UIFieldType.ObjectRefVector),
        new("Disables", UIFieldType.ObjectRefVector),
        new("ShopDisables", UIFieldType.ObjectRefVector),
        new("DisableImages", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("Values", UIFieldType.ObjectRefVector),
        new("Needs", UIFieldType.ObjectRefVector),
        new("NewValues", UIFieldType.ObjectRefVector),
        new("BgIcon", UIFieldType.ObjectRef),
        new("BgImageSetter", UIFieldType.ObjectRef),
        new("Favorite", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
