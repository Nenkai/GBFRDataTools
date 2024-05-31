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
        new("TitleTexts", FieldType.ObjectRefVector),
        new("ButtonGuides", FieldType.ObjectRefVector),
        new("ButtonActiveOwners", FieldType.ObjectRefVector),
        new("NowSetSignObj", FieldType.ObjectRefVector),
        new("NowSetSignText", FieldType.ObjectRefVector),
        new("IconMask", FieldType.ObjectRef),
        new("WeaponInfo", FieldType.ObjectRef),
        new("EmotionInfo", FieldType.ObjectRef),
        new("FixedPhraseInfo", FieldType.ObjectRef),
        new("AutoFixedPhraseInfo", FieldType.ObjectRef),
        new("Icon", FieldType.ObjectRef),
        new("IconImage", FieldType.ObjectRef),
        new("UpdateIcon", FieldType.ObjectRef),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
