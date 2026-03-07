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

public class Em0902FreezeBeamAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0902FreezeBeamAction);

    [JsonPropertyName("attackLoopSec_")]
    public float AttackLoopSec { get; set; } = 1f; // Offset 0x50

    [JsonPropertyName("fallGravity_")]
    public float FallGravity { get; set; } = 0.1f; // Offset 0x54

    [JsonPropertyName("beamShotPosOffset_")]
    public Vector4 BeamShotPosOffset { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x60

    [JsonPropertyName("jumpMotionMoveRate_")]
    public float JumpMotionMoveRate { get; set; } = 1.5f; // Offset 0x70

    [JsonPropertyName("isCancelActionBeamHit_")]
    public bool IsCancelActionBeamHit { get; set; } = true; // Offset 0x74

    public Em0902FreezeBeamAction()
    {
    }
}

