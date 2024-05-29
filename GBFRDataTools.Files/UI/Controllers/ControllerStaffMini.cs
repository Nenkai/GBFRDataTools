using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerStaffMini
public class ControllerStaffMini // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TextID", FieldType.String),
        new("Text", FieldType.ObjectRef),
        new("Titles", FieldType.ObjectRefVector),
        new(0x76774826, FieldType.ObjectRefVector),
        new(0x76EDEFA3, FieldType.ObjectRefVector),
        new(0x8194EE41, FieldType.StringVector),
        new(0x95D07411, FieldType.StringVector),
        new(0xC69B30CE, FieldType.StringVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
