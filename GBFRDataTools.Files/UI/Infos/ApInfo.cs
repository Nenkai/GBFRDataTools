using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::ApInfo
public class ApInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Deactives", UIFieldType.ObjectRefVector),
         new("IdealCovers", UIFieldType.ObjectRefVector),
         new("IconSubs", UIFieldType.ObjectRefVector),
         new(0x5558DE7, UIFieldType.ObjectRefVector),
         new("UnopenedMats", UIFieldType.ObjectRefVector),
         new("RootObj", UIFieldType.ObjectRef),
         new("RootWeaponObj", UIFieldType.ObjectRef),
         new("RootIconObj", UIFieldType.ObjectRef),
         new("LbIcon", UIFieldType.ObjectRef),
         new("AbilityIcon", UIFieldType.ObjectRef),
         new("UpdateIcon", UIFieldType.ObjectRef),
         new("Blank", UIFieldType.ObjectRef),
         new("Acquisition", UIFieldType.ObjectRef),
         new("Releasable", UIFieldType.ObjectRef),
         new("IconSub", UIFieldType.ObjectRef),
         new(0xF1465DD4, UIFieldType.ObjectRef),
         new("Frame", UIFieldType.ObjectRef),
         new("EffectMaskImage", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
