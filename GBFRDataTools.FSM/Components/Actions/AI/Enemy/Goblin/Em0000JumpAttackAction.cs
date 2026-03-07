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
    public float MoveToDist { get; set; } = 6f; // Offset 0x54

    [JsonPropertyName("targetOffset_")]
    public float TargetOffset { get; set; } = 1f; // Offset 0x58

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.1f; // Offset 0x5C

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; // Offset 0x60

    [JsonPropertyName("useGetTargetFunk_")]
    public bool UseGetTargetFunk { get; set; } = false; // Offset 0x64

    [JsonPropertyName("isRollingStart_")]
    public bool IsRollingStart { get; set; } = false; // Offset 0x65

    public Em0000JumpAttackAction()
    {
    }
}
