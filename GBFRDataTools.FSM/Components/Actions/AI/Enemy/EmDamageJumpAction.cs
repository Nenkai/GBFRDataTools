using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmDamageJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmDamageJumpAction);

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.1f;

    [JsonPropertyName("jumpSpeedYCountDecay_")]
    public float JumpSpeedYCountDecay { get; set; } = 0.01f;

    [JsonPropertyName("comboMaxCount_")]
    public int ComboMaxCount { get; set; } = 3;
}
