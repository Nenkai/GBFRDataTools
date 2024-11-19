using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Player;

public class MotionPlayAction : ActionComponent
{
    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("isAnimEnd_")]
    public bool IsAnimEnd { get; set; }

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; }

    [JsonPropertyName("isStartTimeRandom_")]
    public bool IsStartTimeRandom { get; set; }

    [JsonPropertyName("easeOut_")]
    public bool EaseOut { get; set; }

    [JsonPropertyName("animMoveRateXZ_")]
    public float AnimMoveRateXZ { get; set; }

    [JsonPropertyName("animMoveRateY_")]
    public float AnimMoveRateY { get; set; }

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; }

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; }

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; }

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; }

    [JsonPropertyName("motionFlag_")]
    public uint MotionFlag { get; set; }

    [JsonPropertyName("facialSeqNo_")]
    public int FacialSeqNo { get; set; }

    [JsonPropertyName("easeOutStartTime_")]
    public float EaseOutStartTime { get; set; }

    [JsonPropertyName("easeOutTime_")]
    public float EaseOutTime { get; set; }

    [JsonPropertyName("motionWeight_")]
    public float MotionWeight { get; set; }

    [JsonPropertyName("seqNo_")]
    public int SeqNo { get; set; }

}
