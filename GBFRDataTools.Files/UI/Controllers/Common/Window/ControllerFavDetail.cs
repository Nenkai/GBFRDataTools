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
        new("Material", FieldType.ObjectRef),
        new("Gem", FieldType.ObjectRef),
        new("Pendulum", FieldType.ObjectRef),
        new("Info", FieldType.ObjectRef),
        new("Skills", FieldType.ObjectRefVector),
        new("InfoTexts", FieldType.ObjectRefVector),
        new("Restore", FieldType.ObjectRef),
        new("Cancel", FieldType.ObjectRef),
        new("FavText", FieldType.ObjectRef),
        new("Guide", FieldType.ObjectRef),
        new("ItemCount", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
