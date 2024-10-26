using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::EmotionInfo
public class EmotionInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Sets", UIFieldType.ObjectRefVector),
         new("Empties", UIFieldType.ObjectRefVector),
         new("Texts", UIFieldType.ObjectRefVector),
         new("ShortcutSelectObjs", UIFieldType.ObjectRefVector),
         new("ShortcutSelecttexts", UIFieldType.ObjectRefVector),
         new("Icons", UIFieldType.ObjectRefVector),
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
