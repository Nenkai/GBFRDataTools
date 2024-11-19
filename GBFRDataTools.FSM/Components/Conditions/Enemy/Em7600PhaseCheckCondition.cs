using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Enemy;

public class Em7600PhaseCheckCondition : ConditionComponent
{
    [JsonPropertyName("checkBGMPhase_")]
    public int CheckBGMPhase { get; set; }

    [JsonPropertyName("checkSPPhase_")]
    public int CheckSPPhase { get; set; }

    [JsonPropertyName("checkMode_")]
    public int CheckMode { get; set; }
}
