using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemIconStatus
public class ItemIconStatus // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new UIPropertyTypeDef("Status", UIFieldType.ObjectRef),
         new UIPropertyTypeDef("StatusMask", UIFieldType.ObjectRef),
         new UIPropertyTypeDef("StatusEffect", UIFieldType.ObjectRef),
         new UIPropertyTypeDef("Animator", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
