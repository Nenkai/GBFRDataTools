using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy;

public class Em7600PhaseCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7600PhaseCheckCondition);

    [JsonPropertyName("checkBGMPhase_")]
    public int CheckBGMPhase { get; set; } = 0;

    [JsonPropertyName("checkSPPhase_")]
    public int CheckSPPhase { get; set; } = 0;

    [JsonPropertyName("checkMode_")]
    public int CheckMode { get; set; } = 0;
}
