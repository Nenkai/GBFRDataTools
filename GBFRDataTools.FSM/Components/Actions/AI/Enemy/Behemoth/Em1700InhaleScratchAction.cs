using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Behemoth;

public class Em1700InhaleScratchAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1700InhaleScratchAction);

    [JsonPropertyName("inhaleNearDist_")]
    public float InhaleNearDist { get; set; } = 8f; // Offset 0x60

    [JsonPropertyName("inhalefarDist_")]
    public float InhalefarDist { get; set; } = 30f; // Offset 0x64

    [JsonPropertyName("attackSignRadius_")]
    public float AttackSignRadius { get; set; } = 12.5f; // Offset 0x68

    [JsonPropertyName("jumpMoveRate_")]
    public float JumpMoveRate { get; set; } = 3f; // Offset 0x6C

    [JsonPropertyName("isTired_")]
    public bool IsTired { get; set; } = false; // Offset 0x88

    public Em1700InhaleScratchAction()
    {
    }
}
