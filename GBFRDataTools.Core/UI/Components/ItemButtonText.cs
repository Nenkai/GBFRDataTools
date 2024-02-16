using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::ItemButtonText
public class ItemButtonText // Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Texts", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("Button", FieldType.ObjectRef),
         new UIPropertyTypeDef("UpdateIcon", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
