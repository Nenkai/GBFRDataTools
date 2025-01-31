using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::GachaInfo
public class GachaInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("Names", UIFieldType.ObjectRefVector),
        new("TicketCounts", UIFieldType.ObjectRefVector),
        new("FeverConsumeCounts", UIFieldType.ObjectRefVector),
        new("GeenRarityList", UIFieldType.ObjectRefVector),
        new("Pendulums", UIFieldType.ObjectRefVector),
        new("Fevers", UIFieldType.ObjectRefVector),
        new("FeverObjs", UIFieldType.ObjectRefVector),
        new("UpdateIcon", UIFieldType.ObjectRef),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
