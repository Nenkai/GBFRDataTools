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
        new("Icon", FieldType.ObjectRef),
        new("Name", FieldType.ObjectRef),
        new("Value", FieldType.ObjectRef),
        new("Need", FieldType.ObjectRef),
        new("NewValue", FieldType.ObjectRef),
        new("ExplainText", FieldType.ObjectRef),
        new("CanvasGroup", FieldType.ObjectRef),
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("Hides", FieldType.ObjectRefVector),
        new("SetImages", FieldType.ObjectRefVector),
        new("Icons", FieldType.ObjectRefVector),
        new("Lacks", FieldType.ObjectRefVector),
        new("FavLacks", FieldType.ObjectRefVector),
        new("Disables", FieldType.ObjectRefVector),
        new("ShopDisables", FieldType.ObjectRefVector),
        new("DisableImages", FieldType.ObjectRefVector),
        new("Names", FieldType.ObjectRefVector),
        new("Values", FieldType.ObjectRefVector),
        new("Needs", FieldType.ObjectRefVector),
        new("NewValues", FieldType.ObjectRefVector),
        new("BgIcon", FieldType.ObjectRef),
        new("BgImageSetter", FieldType.ObjectRef),
        new("Favorite", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
