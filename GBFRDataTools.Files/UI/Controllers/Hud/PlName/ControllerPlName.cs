using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.PlName;

// ui::component::ControllerPlName
public class ControllerPlName // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x4576721C, UIFieldType.ObjectRef),
        new("Root", UIFieldType.ObjectRef),
        new(0x642AF919, UIFieldType.ObjectRef),
        new("CharaInfo", UIFieldType.ObjectRef),
        new(0x844978E7, UIFieldType.ObjectRef),
        new("BadgeInfo", UIFieldType.ObjectRef),
        new(0x8D4DB3BF, UIFieldType.ObjectRef),
        new(0xAB13F0CD, UIFieldType.ObjectRefVector),
        new(0xAF3F1F02, UIFieldType.ObjectRefVector),
        new(0xBF129A10, UIFieldType.ObjectRef),
        new(0xFCAD148A, UIFieldType.ObjectRef),
        new(0xFD17744C, UIFieldType.ObjectRef),
        new(0xFE1418FF, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
