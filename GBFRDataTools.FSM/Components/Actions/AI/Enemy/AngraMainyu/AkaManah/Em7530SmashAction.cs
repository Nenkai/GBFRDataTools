using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu.AkaManah;

public class Em7530SmashAction : Em7530ActionBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7530SmashAction);

    [JsonPropertyName("stopTime_")]
    public float StopTime { get; set; } = 2f;

    [JsonPropertyName("isCombo_")]
    public bool IsCombo { get; set; } = true;

    [JsonPropertyName("targetHormingMoveMax_")]
    public float TargetHormingMoveMax { get; set; } = 0.2f;

    [JsonPropertyName("chargeWaitVeryEasyTime_")]
    public float ChargeWaitVeryEasyTime { get; set; } = 5f;

    [JsonPropertyName("chargeWaitEasyTime_")]
    public float ChargeWaitEasyTime { get; set; } = 3f;

    [JsonPropertyName("chargeWaitNormalTime_")]
    public float ChargeWaitNormalTime { get; set; } = 3f;

    [JsonPropertyName("chargeWaitHLTime_")]
    public float ChargeWaitHLTime { get; set; } = 0f;

    [JsonPropertyName("chargeWaitHellTime_")]
    public float ChargeWaitHellTime { get; set; } = 0f;
}