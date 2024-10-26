using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemExchangeData
public class ItemExchangeData // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
        new("TitleTexts", UIFieldType.ObjectRefVector),
        new("ButtonGuides", UIFieldType.ObjectRefVector),
        new("ButtonActiveOwners", UIFieldType.ObjectRefVector),
        new("NowSetSignObj", UIFieldType.ObjectRefVector),
        new("NowSetSignText", UIFieldType.ObjectRefVector),
        new("IconMask", UIFieldType.ObjectRef),
        new("WeaponInfo", UIFieldType.ObjectRef),
        new("EmotionInfo", UIFieldType.ObjectRef),
        new("FixedPhraseInfo", UIFieldType.ObjectRef),
        new("AutoFixedPhraseInfo", UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("IconImage", UIFieldType.ObjectRef),
        new("UpdateIcon", UIFieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
