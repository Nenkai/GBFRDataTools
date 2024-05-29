using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemListText
public class ItemListText // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("MirageSets", FieldType.ObjectRefVector),
         new("Name", FieldType.ObjectRef),
         new("Plus", FieldType.ObjectRef),
         new("Unit", FieldType.ObjectRef),
         new("Level", FieldType.ObjectRef),
         new("LevelBg", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
