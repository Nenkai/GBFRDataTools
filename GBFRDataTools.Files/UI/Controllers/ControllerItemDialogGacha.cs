using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerItemDialogGacha
public class ControllerItemDialogGacha // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x146140AF, FieldType.ObjectRef),
        new("MenuDial", FieldType.ObjectRef),
        new(0x1527D75E, FieldType.ObjectRef),
        new(0x1FFF06D0, FieldType.ObjectRef),
        new(0x222603D6, FieldType.ObjectRef),
        new("InfoText", FieldType.ObjectRef),
        new("ErrorText", FieldType.ObjectRef),
        new("DialMax", FieldType.ObjectRef),
        new("Material", FieldType.ObjectRef),
        new(0x7F56FBE9, FieldType.ObjectRef),
        new("WarningText", FieldType.ObjectRef),
        new(0x83ACF9FE, FieldType.ObjectRef),
        new(0x8DEF0F56, FieldType.ObjectRef),
        new(0xAED6E528, FieldType.ObjectRef),
        new(0xC23CD587, FieldType.ObjectRef),
        new(0xEEB00992, FieldType.ObjectRef),
        new(0xF953F0A8, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
