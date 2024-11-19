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

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Furycane;

public class Em7201EventMotionPlayAction : MotionPlayAction
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

    [JsonPropertyName("isUseCutin_")]
    public bool IsUseCutin { get; set; }

    [JsonPropertyName("useCutinTime_")]
    public float UseCutinTime { get; set; }

    [JsonPropertyName("useEndInterTime_")]
    public float UseEndInterTime { get; set; }

    [JsonPropertyName("isCallSoundOnEnd_")]
    public bool IsCallSoundOnEnd { get; set; }

    [JsonPropertyName("soundEventName_")]
    public string SoundEventName { get; set; }
}
