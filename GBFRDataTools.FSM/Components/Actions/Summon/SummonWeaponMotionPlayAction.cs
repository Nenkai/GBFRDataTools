using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonWeaponMotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonWeaponMotionPlayAction);

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("weaponId_")]
    public int WeaponId { get; set; } = 0;

    [JsonPropertyName("isAnimEnd_")]
    public bool IsAnimEnd { get; set; } = false;

    [JsonPropertyName("isAdjustTimeToEnd_")]
    public bool IsAdjustTimeToEnd { get; set; } = false;

    [JsonPropertyName("easeOut_")]
    public bool EaseOut { get; set; } = false;

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = -1f;

    [JsonPropertyName("endTimeToAdjust_")]
    public float EndTimeToAdjust { get; set; } = -1f;

    [JsonPropertyName("interTime_")]
    public float InterTime { get; set; } = -1f;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1f;

    [JsonPropertyName("motionSlot_")]
    public int MotionSlot { get; set; } = 0;

    [JsonPropertyName("motionFlag_")]
    public uint MotionFlag { get; set; } = 0;

    [JsonPropertyName("easeOutStartTime_")]
    public float EaseOutStartTime { get; set; } = -1f;

    [JsonPropertyName("easeOutTime_")]
    public float EaseOutTime { get; set; } = -1f;

    [JsonPropertyName("motionWeight_")]
    public float MotionWeight { get; set; } = 1f;
}
