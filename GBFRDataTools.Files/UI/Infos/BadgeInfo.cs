using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::BadgeInfo
public class BadgeInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("Texts", UIFieldType.ObjectRefVector),
        new("GoldObjs", UIFieldType.ObjectRefVector),
        new("SilverObjs", UIFieldType.ObjectRefVector),
        new("CopperObjs", UIFieldType.ObjectRefVector),
        new("OneLayerObjs", UIFieldType.ObjectRefVector),
        new("FrameImages", UIFieldType.ObjectRefVector),
        new("TitleType", UIFieldType.S32),
        new("UpdateIcon", UIFieldType.ObjectRef),
        new("Explanation", UIFieldType.ObjectRef),
        new("Category", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
