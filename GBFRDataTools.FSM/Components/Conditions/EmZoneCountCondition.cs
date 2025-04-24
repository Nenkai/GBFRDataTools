using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class EmZoneCountCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmZoneCountCondition);

    [JsonPropertyName("zoneCount_")]
    public int ZoneCount { get; set; } = 1; // Offset 0x38

    public EmZoneCountCondition()
    {
    }
}
