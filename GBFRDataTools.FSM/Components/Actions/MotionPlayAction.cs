using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions;

[Description("Plays motion/animation assigned")]
public class MotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(MotionPlayAction);

    [JsonPropertyName("motionIdName_")]
    public /* sys::String */ string MotionIdName { get; set; } = string.Empty;

    [JsonPropertyName("isAnimEnd_")]
    public bool IsAnimEnd { get; set; } = true;

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false;

    [JsonPropertyName("isStartTimeRandom_")]
    public bool IsStartTimeRandom { get; set; } = false;

    [JsonPropertyName("easeOut_")]
    public bool EaseOut { get; set; } = false;

    [JsonPropertyName("animMoveRateXZ_")]
    public float AnimMoveRateXZ { get; set; } = 1.0f;

    [JsonPropertyName("animMoveRateY_")]
    public float AnimMoveRateY { get; set; } = 1.0f;

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = -1.0f;

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = -1.0f;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0;

    [JsonPropertyName("motionFlag_")]
    public uint MotionFlag { get; set; } = 0;

    [JsonPropertyName("facialSeqNo_")]
    public int FacialSeqNo { get; set; } = 0;

    [JsonPropertyName("easeOutStartTime_")]
    public float EaseOutStartTime { get; set; } = 0.0f;

    [JsonPropertyName("easeOutTime_")]
    public float EaseOutTime { get; set; } = 0.0f;

    [JsonPropertyName("motionWeight_")]
    public float MotionWeight { get; set; } = 1.0f;

    [JsonPropertyName("seqNo_")]
    public int SeqNo { get; set; } = 0;

}
