using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Items;

// ui::component::ItemQuestCounterTop
public class ItemQuestCounterTop // : ItemButtonText
{
    public static List<UIPropertyTypeDef> Properties { get; set; } = new()
    {
         new("NewsTexts", UIFieldType.ObjectRefVector),
    };

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ItemButtonText.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
