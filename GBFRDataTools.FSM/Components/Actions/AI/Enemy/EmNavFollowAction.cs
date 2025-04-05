using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmNavFollowAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmNavFollowAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f;

    [JsonPropertyName("turnMaxDegree_")]
    public float TurnMaxDegree { get; set; } = 30.0f;

    [JsonPropertyName("turnOffsetDegree_")]
    public float TurnOffsetDegree { get; set; } = 0.0f;

    [JsonPropertyName("attackHomingFlagOnly_")]
    public bool AttackHomingFlagOnly { get; set; } = false;

    [JsonPropertyName("navRecalcSec_")]
    public float NavRecalcSec { get; set; } = -1.0f;
}
