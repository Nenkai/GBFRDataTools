using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::SkinInfo
public class SkinInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", FieldType.ObjectRefVector),
        new("Empties", FieldType.ObjectRefVector),
        new("Skin", FieldType.ObjectRef),
        new("Name", FieldType.ObjectRef),
        new("Info", FieldType.ObjectRef),
        new("EquipIcon", FieldType.ObjectRef),
        new("UpdateIcon", FieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
