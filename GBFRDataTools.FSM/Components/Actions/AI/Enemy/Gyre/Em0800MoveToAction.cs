using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0800MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0800MoveToAction);

    [JsonPropertyName("checkRange_")]
    public int CheckRange { get; set; } = 0; // Offset 0x3C

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 4f; // Offset 0x38

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = false; // Offset 0x44

    [JsonPropertyName("isMoveToLookTargetPos_")]
    public bool IsMoveToLookTargetPos { get; set; } = false; // Offset 0x46

    [JsonPropertyName("checkMoveEndStartMotion_")]
    public bool CheckMoveEndStartMotion { get; set; } = false; // Offset 0x45

    [JsonPropertyName("moveRateXZ_")]
    public float MoveRateXZ { get; set; } = 1f; // Offset 0x48

    [JsonPropertyName("moveRateY_")]
    public float MoveRateY { get; set; } = 1f; // Offset 0x4C

    public Em0800MoveToAction()
    {
    }
}
