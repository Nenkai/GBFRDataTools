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
    public int ChaosLineType { get; set; } = 0; // Offset 0x30

    [JsonPropertyName("thunderNum_")]
    public int ThunderNum { get; set; } = 11; // Offset 0x34

    [JsonPropertyName("thunderIntervalDist_")]
    public float ThunderIntervalDist { get; set; } = 4f; // Offset 0x38

    [JsonPropertyName("thunderIntervalTime_")]
    public float ThunderIntervalTime { get; set; } = 0.05f; // Offset 0x3C

    [JsonPropertyName("thunderCrossRot_")]
    public float ThunderCrossRot { get; set; } = 90f; // Offset 0x40

    [JsonPropertyName("thunderTargetDist_")]
    public float ThunderTargetDist { get; set; } = 20f; // Offset 0x44

    public Em1700ChaosLineAction()
    {
    }
}
