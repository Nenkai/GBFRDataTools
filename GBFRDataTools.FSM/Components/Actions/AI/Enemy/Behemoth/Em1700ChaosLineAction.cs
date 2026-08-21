using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700ChaosLineAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700ChaosLineAction);

    [JsonPropertyName("chaosLineType_")]
    public int ChaosLineType { get; set; } = 0;

    [JsonPropertyName("thunderNum_")]
    public int ThunderNum { get; set; } = 11;

    [JsonPropertyName("thunderIntervalDist_")]
    public float ThunderIntervalDist { get; set; } = 4f;

    [JsonPropertyName("thunderIntervalTime_")]
    public float ThunderIntervalTime { get; set; } = 0.05f;

    [JsonPropertyName("thunderCrossRot_")]
    public float ThunderCrossRot { get; set; } = 90f;

    [JsonPropertyName("thunderTargetDist_")]
    public float ThunderTargetDist { get; set; } = 20f;
}
