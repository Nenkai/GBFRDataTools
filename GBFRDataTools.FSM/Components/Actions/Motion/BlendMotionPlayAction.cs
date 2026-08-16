using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Motion;

[Description("Plays motion/animation assigned")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class BlendMotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BlendMotionPlayAction);

    [JsonPropertyName("isAnimEnd_")]
    public bool IsAnimEnd { get; set; } = true;

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false;

    [JsonPropertyName("isStartTimeRandom_")]
    public bool IsStartTimeRandom { get; set; } = false;

    [JsonPropertyName("isAdjustTimeToEnd_")]
    public bool IsAdjustTimeToEnd { get; set; } = false;

    [JsonPropertyName("easeOut_")]
    public bool EaseOut { get; set; } = false;

    [JsonPropertyName("animMoveRateXZ_")]
    public float AnimMoveRateXZ { get; set; } = 1f;

    [JsonPropertyName("animMoveRateY_")]
    public float AnimMoveRateY { get; set; } = 1f;

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = -1f;

    [JsonPropertyName("endTimeToAdjust_")]
    public float EndTimeToAdjust { get; set; } = -1f;

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = 0f;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1f;

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0;

    [JsonPropertyName("motionFlag_")]
    public uint MotionFlag { get; set; } = 0;

    [JsonPropertyName("facialSeqNo_")]
    public int FacialSeqNo { get; set; } = 0;

    [JsonPropertyName("easeOutStartTime_")]
    public float EaseOutStartTime { get; set; } = -1f;

    [JsonPropertyName("easeOutTime_")]
    public float EaseOutTime { get; set; } = -1f;

    [JsonPropertyName("motionWeight_")]
    public float MotionWeight { get; set; } = 1f;

    [JsonPropertyName("seqNo_")]
    public int SeqNo { get; set; } = 0;

    [JsonPropertyName("blendMotionNames_")]
    public BindingList<BlendMotionName> BlendMotionNames { get; set; } = []; // std::vector<BT::BlendMotionPlayAction::BlendMotionName>

    [JsonPropertyName("blendRateBBValueName_")]
    public string BlendRateBBValueName { get; set; }

    [JsonPropertyName("blendInterRate_")]
    public float BlendInterRate { get; set; } = 0.1f;

    public class BlendMotionName
    {
        [JsonPropertyName("motionIdName_")]
        public string MotionIdName { get; set; }

        [JsonPropertyName("blendPoint_")]
        public Vector4 BlendPoint { get; set; } = Vector4.UnitW;
    }
}
