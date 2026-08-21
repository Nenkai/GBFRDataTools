using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300TargetArcMoveAction : We7300TargetMoveBase
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300TargetArcMoveAction);

    [JsonPropertyName("initPosType_")]
    public int InitPosType { get; set; } = 0; 

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.5f; 

    [JsonPropertyName("waitTimeIndex_")]
    public float WaitTimeIndex { get; set; } = 0.2f; 

    [JsonPropertyName("arcTime_")]
    public float ArcTime { get; set; } = 2f; 

    [JsonPropertyName("arcEndRate_")]
    public float ArcEndRate { get; set; } = 0.7f; 

    [JsonPropertyName("arcVectorScale_")]
    public float ArcVectorScale { get; set; } = 10f; 

    [JsonPropertyName("arcAddHeight_")]
    public float ArcAddHeight { get; set; } = 2f; 

    [JsonPropertyName("arcAddSide_")]
    public float ArcAddSide { get; set; } = 2f;

    [JsonPropertyName("arcCurve_")]
    public GuiImportableCurve<float> ArcCurve { get; set; } = new();

    [JsonPropertyName("rateCurve_")]
    public GuiImportableCurve<float> RateCurve { get; set; } = new();
}
