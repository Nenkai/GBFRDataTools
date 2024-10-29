using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::FixedPhraseInfo
public class FixedPhraseInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("TitleTexts", UIFieldType.ObjectRefVector),
        new("FixedPhraseTexts", UIFieldType.ObjectRefVector),
        new("EnableObjs", UIFieldType.ObjectRefVector),
        new("FixedPhraseInfo", UIFieldType.ObjectRef),
        new("Texts", UIFieldType.ObjectRefVector),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new("IconImage", UIFieldType.ObjectRef),
        new("Icon", UIFieldType.ObjectRef),
        new("EmotionDataSets", UIFieldType.ObjectRefVector),
        new("ShortcutSelectObjs", UIFieldType.ObjectRefVector),
        new("ShortcutSelecttexts", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
