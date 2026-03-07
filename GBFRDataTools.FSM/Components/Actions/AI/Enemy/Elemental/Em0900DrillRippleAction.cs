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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Elemental;

public class Em0900DrillRippleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0900DrillRippleAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x80

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; // Offset 0x84

    [JsonPropertyName("rippleLoopMax_")]
    public int RippleLoopMax { get; set; } = 1; // Offset 0x94

    [JsonPropertyName("rippleAttackAddRotY_")]
    public float RippleAttackAddRotY { get; set; } = 1.2f; // Offset 0x90

    [JsonPropertyName("jumpMotionMoveRate_")]
    public float JumpMotionMoveRate { get; set; } = 1.2f; // Offset 0x88

    [JsonPropertyName("fallAttackAreaDist_")]
    public float FallAttackAreaDist { get; set; } = 2f; // Offset 0x8C

    public Em0900DrillRippleAction()
    {
    }
}

