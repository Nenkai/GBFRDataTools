using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::AbilityInfo
public class AbilityInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector), // D0A7B41
        new("Empties", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector), // A8C20CB5
        new("Types", UIFieldType.ObjectRefVector),
        new("Status", UIFieldType.ObjectRefVector),
        new("Buttons", UIFieldType.ObjectRefVector),
        new("Elements", UIFieldType.ObjectRefVector), // 1C864810
        new(0xF7B5F034, UIFieldType.ObjectRefVector),

        new("Icon", UIFieldType.ObjectRef), // F2856FD4
        new("Frame", UIFieldType.ObjectRef), // B1073935
        new("UpdateIcon", UIFieldType.ObjectRef), // CFFD7733
        new(0x4053E19C, UIFieldType.ObjectRef),
        new("Movie", UIFieldType.ObjectRef), // C987BAD6
        new("Info", UIFieldType.ObjectRef), // 53380230
        new("Selector", UIFieldType.ObjectRef), // E36BB4D7
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
