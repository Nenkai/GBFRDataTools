using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::StatusInfo
public class StatusInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", FieldType.ObjectRefVector),
        new("Levels", FieldType.ObjectRefVector),
        new("Texts", FieldType.ObjectRefVector),
        new("Arrows", FieldType.ObjectRefVector),
        new("Info", FieldType.ObjectRef),
        new(0xE9F53907, FieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
