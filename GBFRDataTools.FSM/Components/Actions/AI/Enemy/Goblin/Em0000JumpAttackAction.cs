using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000JumpAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000JumpAttackAction);

    [JsonPropertyName("moveToDist_")]
    public float MoveToDist { get; set; } = 6f; 

    [JsonPropertyName("targetOffset_")]
    public float TargetOffset { get; set; } = 1f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.1f; 

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; 

    [JsonPropertyName("useGetTargetFunk_")]
    public bool UseGetTargetFunk { get; set; } = false; 

    [JsonPropertyName("isRollingStart_")]
    public bool IsRollingStart { get; set; } = false; 
}
