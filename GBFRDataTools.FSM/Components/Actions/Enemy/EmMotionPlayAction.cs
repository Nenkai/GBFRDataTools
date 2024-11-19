using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmMotionPlayAction : MotionPlayAction
{
    [JsonPropertyName("useTurnDir_")]
    public bool UseTurnDir { get; set; }

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; }

    [JsonPropertyName("turnMaxAngle_")]
    public float TurnMaxAngle { get; set; }

    [JsonPropertyName("turnOffsetAngle_")]
    public float TurnOffsetAngle { get; set; }

    [JsonPropertyName("attackHomingFlagOnly_")]
    public bool AttackHomingFlagOnly { get; set; }

    [JsonPropertyName("endSec_")]
    public float EndSec { get; set; }

    [JsonPropertyName("isChangeSequenceLayer_")]
    public bool IsChangeSequenceLayer { get; set; }

    [JsonPropertyName("sequenceLayer_")]
    public uint SequenceLayer { get; set; }
}

