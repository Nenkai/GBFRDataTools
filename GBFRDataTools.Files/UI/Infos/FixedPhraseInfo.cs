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
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("TitleTexts", FieldType.ObjectRefVector),
        new("FixedPhraseTexts", FieldType.ObjectRefVector),
        new("EnableObjs", FieldType.ObjectRefVector),
        new("FixedPhraseInfo", FieldType.ObjectRef),
        new("Texts", FieldType.ObjectRefVector),
        new("UpdateIcon", FieldType.ObjectRef),
        new("IconImage", FieldType.ObjectRef),
        new("Icon", FieldType.ObjectRef),
        new(0x5C9CFD83, FieldType.ObjectRefVector),
        new("ShortcutSelectObjs", FieldType.ObjectRefVector),
        new("ShortcutSelecttexts", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
