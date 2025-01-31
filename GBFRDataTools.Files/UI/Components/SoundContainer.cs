using GBFRDataTools.Hashing;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBFRDataTools.Files.UI.Components;

// ui::component::SoundContainer
public class SoundContainer // : Component
{
    public static List<UIPropertyTypeDef> Properties { get; set; } =
    [
        new("Decide", UIFieldType.String), // 61743B79
        new("Decide02", UIFieldType.String), // EB1C1CFD
        new("Decide03", UIFieldType.String), // 8805C9BC
        new("Decide04", UIFieldType.String),
        new("Decide05", UIFieldType.String),
        new("Cancel", UIFieldType.String), // 8A1E3E33
        new("Error", UIFieldType.String), // 35A33DD3
        new("CursorUd", UIFieldType.String), // CB5144E5
        new("CursorLr", UIFieldType.String), // BC50429B
        new("Cursor", UIFieldType.String), // 67078166
        new("TabLr", UIFieldType.String), // 7BD8E28E
        new("WindowOpen", UIFieldType.String), // 697D78B1
        new("WindowClose", UIFieldType.String), // 6CF24747
        new("Add", UIFieldType.String), // 90A4682B
        new("Sub", UIFieldType.String), // 84BE1B4F
        new("Max", UIFieldType.String), // 72D4C752
        new("Other1", UIFieldType.String), // 0xB0CB7651
        new("Other2", UIFieldType.String), // 0x694F6E82
        new(0x9E3CEC6F, UIFieldType.String),
        new("SelectLock", UIFieldType.String), // 9C47B7A7
        new("SelectDecide", UIFieldType.String), // B4EE130F
        new("SelectCancel", UIFieldType.String), // 8C4AE5F7
        new("Level1", UIFieldType.String), // DA6FFB4E
        new("Level2", UIFieldType.String), // 691BDEFB
        new("Level3", UIFieldType.String), // 8C106E4D
        new("Level4", UIFieldType.String), // A033C91A
        new("Level5", UIFieldType.String), // FBBE3946
        new("Index", UIFieldType.String), // 32BE30
        new("Choice", UIFieldType.String), // DFE3F296
        new("Sort", UIFieldType.String), // B13F196B
        new("Remove", UIFieldType.String), // C875F857
        new("Other3", UIFieldType.String), // 66135E77
        new("Other4", UIFieldType.String), // 0x56BEB00E
        new("Other5", UIFieldType.String), // E1607962
        new("Other6", UIFieldType.String), // 696CCB49
        new("Levelup", UIFieldType.String), // 0xC541EC52
        new(0x6D626858, UIFieldType.String),
        new("Count1", UIFieldType.String), // 8F226B5B
        new("Count2", UIFieldType.String), // 3B4DA4F7
        new("Count3", UIFieldType.String), // 7DE7FAC9
        new("Count4", UIFieldType.String), // 1ADEBB0B
        new("Count5", UIFieldType.String), // 8FD82F6F
        new("Count610", UIFieldType.String), // 7747978A
        new("PlaybackInFade", UIFieldType.Bool), // 57088074
    ];

    public static List<UIPropertyTypeDef> GetAllProperties()
    {
        var list = new List<UIPropertyTypeDef>();
        list.AddRange(Component.Properties);
        list.AddRange(Properties);
        return list;
    }
}
