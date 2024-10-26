using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.InfoCmn;

// ui::component::ControllerInformationToast
public class ControllerInformationToast // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new(0x3F3DDC33, UIFieldType.ObjectRefVector),
        new(0x4A793E4F, UIFieldType.ObjectRefVector),
        new(0x6C95FBA8, UIFieldType.ObjectRef),
        new(0x849799EB, UIFieldType.ObjectRefVector),
        new("Canvas", UIFieldType.ObjectRef),
        new(0x9C794271, UIFieldType.ObjectRefVector),
        new(0xB4B9959A, UIFieldType.ObjectRefVector),
        new(0xB5BB4C4D, UIFieldType.ObjectRefVector),
        new(0xCFB75687, UIFieldType.ObjectRef),
        new(0xD58D7284, UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
