using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::ScrollText
public class ScrollText // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Texts", UIFieldType.ObjectRefVector),
         new("Mask", UIFieldType.ObjectRef),
         new(0xB325F0DF, UIFieldType.ObjectRef),
         new(0x8ECB9DB9, UIFieldType.F32),
         new("ScrollMode", UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
