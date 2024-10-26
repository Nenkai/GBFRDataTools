using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers.Common.Window;

// ui::component::ControllerFavDetail
public class ControllerFavDetail // : Controller
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Material", UIFieldType.ObjectRef),
        new("Gem", UIFieldType.ObjectRef),
        new("Pendulum", UIFieldType.ObjectRef),
        new("Info", UIFieldType.ObjectRef),
        new("Skills", UIFieldType.ObjectRefVector),
        new("InfoTexts", UIFieldType.ObjectRefVector),
        new("Restore", UIFieldType.ObjectRef),
        new("Cancel", UIFieldType.ObjectRef),
        new("FavText", UIFieldType.ObjectRef),
        new("Guide", UIFieldType.ObjectRef),
        new("ItemCount", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
