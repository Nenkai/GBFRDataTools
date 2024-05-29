using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Controllers;

// ui::component::ControllerStaffText
public class ControllerStaffText // : ControllerStaffBase
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Colums", FieldType.ObjectRefVector),
        new("OneName", FieldType.ObjectRefVector),
        new("TwoNames", FieldType.ObjectRefVector),
        new("ThreeNames", FieldType.ObjectRefVector),
        new("FourNames", FieldType.ObjectRefVector),
        new("FiveNames", FieldType.ObjectRefVector),
        //new("FiveNames", FieldType.ObjectRefVector), for some reason this is duped on their end lol.
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(ControllerStaffBase.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
