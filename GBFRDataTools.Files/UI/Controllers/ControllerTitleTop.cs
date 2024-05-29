using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerTitleTop
public class ControllerTitleTop // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x40BE2107, FieldType.ObjectRefVector),
        new(0xE62B1B7F, FieldType.ObjectRef),
        new(0x7419B8C1, FieldType.ObjectRef),
        new(0xC987BAD6, FieldType.ObjectRef),
        new(0xFC1A9DEB, FieldType.ObjectRef),
        new(0x51BDB018, FieldType.ObjectRef),
        new(0x3C68C98E, FieldType.ObjectRef),
        new(0x2D46B514, FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
