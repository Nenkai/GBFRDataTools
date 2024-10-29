using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerItemDialogGacha
public class ControllerItemDialogGacha // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x146140AF, UIFieldType.ObjectRef),
        new("MenuDial", UIFieldType.ObjectRef),
        new(0x1527D75E, UIFieldType.ObjectRef),
        new("ItemCount", UIFieldType.ObjectRef),
        new(0x222603D6, UIFieldType.ObjectRef),
        new("InfoText", UIFieldType.ObjectRef),
        new("ErrorText", UIFieldType.ObjectRef),
        new("DialMax", UIFieldType.ObjectRef),
        new("Material", UIFieldType.ObjectRef),
        new("MenuCount", UIFieldType.ObjectRef),
        new("WarningText", UIFieldType.ObjectRef),
        new("MenuChoice", UIFieldType.ObjectRef),
        new("InfoTextObj", UIFieldType.ObjectRef),
        new(0xAED6E528, UIFieldType.ObjectRef),
        new(0xC23CD587, UIFieldType.ObjectRef),
        new(0xEEB00992, UIFieldType.ObjectRef),
        new(0xF953F0A8, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
