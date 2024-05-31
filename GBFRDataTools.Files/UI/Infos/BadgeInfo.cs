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
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("Texts", FieldType.ObjectRefVector),
        new("GoldObjs", FieldType.ObjectRefVector),
        new("SilverObjs", FieldType.ObjectRefVector),
        new("CopperObjs", FieldType.ObjectRefVector),
        new("OneLayerObjs", FieldType.ObjectRefVector),
        new("FrameImages", FieldType.ObjectRefVector),
        new("TitleType", FieldType.S32),
        new("UpdateIcon", FieldType.ObjectRef),
        new("Explanation", FieldType.ObjectRef),
        new("Category", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
