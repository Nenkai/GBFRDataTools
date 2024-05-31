using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Hud.ExCharacter;

// ui::component::ControllerExChr23
public class ControllerExChr23 // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x11418516, FieldType.ObjectRef),
        new(0x1F070440, FieldType.ObjectRef),
        new(0xCB3623FB, FieldType.ObjectRef),
        new(0xB27A3BB2, FieldType.ObjectRef),
        new(0xBD19B446, FieldType.ObjectRef),
        new("Root", FieldType.ObjectRef),
        new("Arrows", FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
