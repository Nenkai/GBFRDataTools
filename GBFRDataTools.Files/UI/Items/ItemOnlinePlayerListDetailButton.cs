using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemOnlinePlayerListDetailButton
public class ItemOnlinePlayerListDetailButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Obj", FieldType.ObjectRef),
         new("Icons", FieldType.ObjectRefVector),
         new("Texts", FieldType.ObjectRefVector),
         new("GrayOutImages", FieldType.ObjectRefVector),
         new("GrayOutTexts", FieldType.ObjectRefVector),
         new("Button", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
