using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ButtonLabel
public class ButtonLabel // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("Cursor", FieldType.ObjectRef),
        new("Button", FieldType.ObjectRef),
        new("Text", FieldType.ObjectRef),
        new("ImageButton", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
