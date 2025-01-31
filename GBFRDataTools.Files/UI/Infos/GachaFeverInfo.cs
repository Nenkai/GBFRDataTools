using GBFRDataTools.Files.UI.Components;
using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Infos;

// ui::component::GachaFeverInfo
public class GachaFeverInfo // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Sets", UIFieldType.ObjectRefVector), // D0A7B41
        new("Empties", UIFieldType.ObjectRef), // 0x49ADD487
        new("ExecuteCounts", UIFieldType.ObjectRefVector), // D31D1E55
        new("NextCounts", UIFieldType.ObjectRefVector), // 7DE930F6
        new("ExecuteCountMax", UIFieldType.ObjectRef), // 74B5DE0E
        new("Gauge", UIFieldType.ObjectRef), // 198AC99F
        new(0x26EB6D24, UIFieldType.ObjectRef),
        new(0x6EF2AC4A, UIFieldType.ObjectRef),
        new("CompareExecuteCount", UIFieldType.ObjectRef), // A736CEA9
        new("CompareGauge", UIFieldType.ObjectRef), // D0605437
        new("CompareNextCount", UIFieldType.ObjectRef), // 7F512816
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
