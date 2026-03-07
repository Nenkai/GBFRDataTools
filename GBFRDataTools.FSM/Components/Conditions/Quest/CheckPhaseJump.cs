using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class CheckPhaseJump : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckPhaseJump);

    [JsonPropertyName("isPhaseIn_")]
    public bool IsPhaseIn { get; set; } = false;

    [JsonPropertyName("phaseNo_")]
    public int PhaseNo { get; set; } = 0;

}
