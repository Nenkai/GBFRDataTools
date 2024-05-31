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
         new("Sets", FieldType.ObjectRefVector),
         new("Empties", FieldType.ObjectRefVector),
         new("Texts", FieldType.ObjectRefVector),
         new("ShortcutSelectObjs", FieldType.ObjectRefVector),
         new("ShortcutSelecttexts", FieldType.ObjectRefVector),
         new("Icons", FieldType.ObjectRefVector),
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
