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
    public int InitPosType { get; set; } = 0; // Offset 0x90

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.5f; // Offset 0x94

    [JsonPropertyName("waitTimeIndex_")]
    public float WaitTimeIndex { get; set; } = 0.2f; // Offset 0x98

    [JsonPropertyName("arcTime_")]
    public float ArcTime { get; set; } = 2f; // Offset 0x9C

    [JsonPropertyName("arcEndRate_")]
    public float ArcEndRate { get; set; } = 0.7f; // Offset 0xA0

    [JsonPropertyName("arcVectorScale_")]
    public float ArcVectorScale { get; set; } = 10f; // Offset 0xA4

    [JsonPropertyName("arcAddHeight_")]
    public float ArcAddHeight { get; set; } = 2f; // Offset 0xA8

    [JsonPropertyName("arcAddSide_")]
    public float ArcAddSide { get; set; } = 2f; // Offset 0xAC

    [JsonPropertyName("arcCurve_")]
    public GuiImportableCurve<float> ArcCurve { get; set; } // Offset 0xB0

    [JsonPropertyName("rateCurve_")]
    public GuiImportableCurve<float> RateCurve { get; set; } // Offset 0xD8

    public We7300TargetArcMoveAction()
    {
    }
}
