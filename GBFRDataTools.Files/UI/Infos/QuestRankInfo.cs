using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::QuestRankInfo
public class QuestRankInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector),
        new("Empties", UIFieldType.ObjectRefVector),
        new("RankNames", UIFieldType.ObjectRefVector),
        new("RankTextColorSetters", UIFieldType.ObjectRefVector),
        new("MultiQuestTypeIcons", UIFieldType.ObjectRefVector),
        new("MultiQuestTypeObjects", UIFieldType.ObjectRefVector),
        new("QuestRankImages", UIFieldType.ObjectRefVector),
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
