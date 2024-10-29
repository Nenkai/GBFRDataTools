using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.GuideAction;

// ui::component::ControllerHudQuestReady
public class ControllerHudQuestReady // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x0F564B17, UIFieldType.ObjectRef),
        new(0x14E5E0EB, UIFieldType.ObjectRef),
        new(0x2A303C81, UIFieldType.ObjectRef),
        new(0x4C8680A2, UIFieldType.ObjectRef),
        new(0x73368966, UIFieldType.ObjectRef),
        new(0xC9DBF0BF, UIFieldType.ObjectRef),
        new(0xD0842CDD, UIFieldType.ObjectRef),
        new("QuestInfo", UIFieldType.ObjectRef),
        new("Root", UIFieldType.ObjectRef),
        new("ButtonGuides", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
