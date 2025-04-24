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

public class Em0902CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0902CounterAction);

    [JsonPropertyName("shotFreezeGasNum_")]
    public int ShotFreezeGasNum { get; set; } = 8; // Offset 0x84

    [JsonPropertyName("shotOffsetPos_")]
    public Vector4 ShotOffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x90

    [JsonPropertyName("loopSec_")]
    public float LoopSec { get; set; } = 1.2f; // Offset 0x88

    [JsonPropertyName("motionMoveRate_")]
    public float MotionMoveRate { get; set; } = 0.5f; // Offset 0xA0

    [JsonPropertyName("isLoopAnimEnd_")]
    public bool IsLoopAnimEnd { get; set; } = false; // Offset 0xA4

    [JsonPropertyName("signSec_")]
    public float SignSec { get; set; } = 0.5f; // Offset 0xA8

    [JsonPropertyName("signLength_")]
    public float SignLength { get; set; } = 5f; // Offset 0xAC

    [JsonPropertyName("loopShowSignSec_")]
    public float LoopShowSignSec { get; set; } = 1.2f; // Offset 0xB0

    public Em0902CounterAction()
    {
    }
}

