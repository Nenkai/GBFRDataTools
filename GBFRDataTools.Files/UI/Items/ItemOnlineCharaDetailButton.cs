using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemOnlineCharaDetailButton
public class ItemOnlineCharaDetailButton // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Obj", UIFieldType.ObjectRef),
         new("Icons", UIFieldType.ObjectRefVector),
         new("Texts", UIFieldType.ObjectRefVector),
         new("GrayOutImages", UIFieldType.ObjectRefVector),
         new("GrayOutTexts", UIFieldType.ObjectRefVector),
         new("Button", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
