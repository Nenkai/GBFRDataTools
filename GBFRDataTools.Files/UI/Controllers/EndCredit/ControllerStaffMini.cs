using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.EndCredit;

// ui::component::ControllerStaffMini
public class ControllerStaffMini // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("TextID", UIFieldType.String),
        new("Text", UIFieldType.ObjectRef),
        new("Titles", UIFieldType.ObjectRefVector),
        new(0x76774826, UIFieldType.ObjectRefVector),
        new(0x76EDEFA3, UIFieldType.ObjectRefVector),
        new(0x8194EE41, UIFieldType.StringVector),
        new(0x95D07411, UIFieldType.StringVector),
        new(0xC69B30CE, UIFieldType.StringVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
