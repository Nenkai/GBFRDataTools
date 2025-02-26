using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmMotionPlayAction : MotionPlayAction
{
    [JsonPropertyName("useTurnDir_")]
    public bool UseTurnDir { get; set; } = false;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.3f;

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; } = MathF.PI / 6; // 30°, 0.52359879

    [JsonPropertyName("turnOffsetAngle_")]
    public float TurnOffsetAngle { get; set; } = 0.0f;

    [JsonPropertyName("attackHomingFlagOnly_")]
    public bool AttackHomingFlagOnly { get; set; } = false;

    [JsonPropertyName("endSec_")]
    public float EndSec { get; set; } = -1.0f;

    [JsonPropertyName("isChangeSequenceLayer_")]
    public bool IsChangeSequenceLayer { get; set; } = false;

    [JsonPropertyName("sequenceLayer_")]
    public uint SequenceLayer { get; set; } = 0;
}

