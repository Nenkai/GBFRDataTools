using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestRankTab
public class ItemQuestRankTab // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("Texts", UIFieldType.ObjectRefVector),
         new("TabFrameIamge", UIFieldType.ObjectRef), // Cy typo - "Image" -> "Iamge"
         new("TabFrameImageSetter", UIFieldType.ObjectRef),
         new("Button", UIFieldType.ObjectRef),
         new("TabPosition", UIFieldType.S32),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);

        return list;
    }
}
