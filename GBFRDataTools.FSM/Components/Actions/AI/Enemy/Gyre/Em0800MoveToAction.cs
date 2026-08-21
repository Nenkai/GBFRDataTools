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
    public int CheckRange { get; set; } = 0; 

    [JsonPropertyName("checkRangeDistanceOffset_")]
    public float CheckRangeDistanceOffset { get; set; } = 0f; 

    [JsonPropertyName("jumpHeightMin_")]
    public float JumpHeightMin { get; set; } = 4f; 

    [JsonPropertyName("skipEndMotion_")]
    public bool SkipEndMotion { get; set; } = false; 

    [JsonPropertyName("isMoveToLookTargetPos_")]
    public bool IsMoveToLookTargetPos { get; set; } = false; 

    [JsonPropertyName("checkMoveEndStartMotion_")]
    public bool CheckMoveEndStartMotion { get; set; } = false; 

    [JsonPropertyName("moveRateXZ_")]
    public float MoveRateXZ { get; set; } = 1f; 

    [JsonPropertyName("moveRateY_")]
    public float MoveRateY { get; set; } = 1f; 
}
