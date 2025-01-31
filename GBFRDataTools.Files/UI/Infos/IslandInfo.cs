using GBFRDataTools.Files.UI.Controllers;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::IslandInfo
public class IslandInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("Release", UIFieldType.ObjectRefVector),
        new("KeyQuestObjects", UIFieldType.ObjectRefVector),
        new("RankupQuestObjects", UIFieldType.ObjectRefVector),
        new("IslandName", UIFieldType.ObjectRef),
        new("IslandNames", UIFieldType.ObjectRefVector),
        new("KeyQuestCounts", UIFieldType.ObjectRefVector),
        new("RankupQuestCounts", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Controller.GetAllProperties());
        list.AddRange(Properties);
        return list;
    }
}
