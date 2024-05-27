using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ElementInfo
public class ElementInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Sets", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("Empties", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("InvalidOffs", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("Images", FieldType.ObjectRefVector),
         new UIPropertyTypeDef("Texts", FieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
