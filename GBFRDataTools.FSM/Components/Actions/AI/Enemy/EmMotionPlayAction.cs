using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmMotionPlayAction : MotionPlayAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmMotionPlayAction);

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

    public EmMotionPlayAction()
    {
        IsAnimEnd = true;
        Loop = false;
        IsStartTimeRandom = false;
        EaseOut = false;
        AnimMoveRateXZ = 1f;
        AnimMoveRateY = 1f;
        StartTime = -1f;
        InterTime = -1f;
        SpeedRate = 1f;
        MotionSlot = 0;
        MotionFlag = 0;
        FacialSeqNo = 0;
        EaseOutStartTime = -1f;
        EaseOutTime = -1f;
        MotionWeight = 1f;
        SeqNo = 0;
    }
}

