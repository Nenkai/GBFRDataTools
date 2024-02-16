using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Core.UI.Components;

// ui::component::CharaInfo
public class CharaInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new UIPropertyTypeDef(0x8E1CB3E3, FieldType.ObjectRefVector),
        new UIPropertyTypeDef(0x930C5152, FieldType.ObjectRef),
        new UIPropertyTypeDef(0xF272EF26, FieldType.ObjectRef),
        new UIPropertyTypeDef(0xF2856FD4, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
