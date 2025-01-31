using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Pause.Controller_;

// ui::component::ControllerSystemPad
public class ControllerSystemPad // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("PressTexts", UIFieldType.ObjectRefVector), // 75554EB3
        new("DefaultPressIDs", UIFieldType.StringVector), // 6319FA97
        new("PushTexts", UIFieldType.ObjectRefVector), // 8E94CD41
        new("DefaultPushIDs", UIFieldType.StringVector), // 907AF460
        new("OfflineEmptys", UIFieldType.ObjectRefVector), // AD8696DE
        new(0x4F11DB50, UIFieldType.ObjectRefVector),
        new(0xB21BF3FA, UIFieldType.ObjectRefVector),
        new(0x9A1B7F75, UIFieldType.ObjectRefVector),
        new(0x51F00B24, UIFieldType.ObjectRefVector),
        new("Lock", UIFieldType.ObjectRef), // 8549BD5E
        new("Guard", UIFieldType.ObjectRef), // 4F62AE7F
        new("RootCity", UIFieldType.ObjectRef), // 6F363463
        new("RootBattle", UIFieldType.ObjectRef), // 86259E74
        new(0x28D167AA, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controllers.Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
