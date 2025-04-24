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

public class Em0902DrillAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0902DrillAction);

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 10f; // Offset 0x54

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; // Offset 0x50

    [JsonPropertyName("jumpMotionMoveRate_")]
    public float JumpMotionMoveRate { get; set; } = 1.2f; // Offset 0x58

    [JsonPropertyName("fallAttackAreaDist_")]
    public float FallAttackAreaDist { get; set; } = 2.5f; // Offset 0x5C

    public Em0902DrillAction()
    {
    }
}

