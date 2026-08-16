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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.BallisticBallista;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4200WaitAndBoostDashAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4200WaitAndBoostDashAction);

    [JsonPropertyName("stickThreshold_")]
    public float StickThreshold { get; set; } = 300f;

    [JsonPropertyName("boostSpeed_")]
    public float BoostSpeed { get; set; } = 0.65f;

    [JsonPropertyName("boostMoveDisableTime_")]
    public float BoostMoveDisableTime { get; set; } = 0.15f;

    [JsonPropertyName("boostCancelDisableTime_")]
    public float BoostCancelDisableTime { get; set; } = 0.3f;

    [JsonPropertyName("boostAccelTime_")]
    public float BoostAccelTime { get; set; } = 0.3f;

    [JsonPropertyName("boostSpeedRate_")]
    public float BoostSpeedRate { get; set; } = 0.6f;

    [JsonPropertyName("boostDecelTime_")]
    public float BoostDecelTime { get; set; } = 0.5f;

    [JsonPropertyName("boostDecelAddSpeed_")]
    public float BoostDecelAddSpeed { get; set; } = 0.5f;

    [JsonPropertyName("boostVfxObjId_")]
    [eObjId]
    public uint BoostVfxObjId { get; set; } = 0x10D_4100;

    [JsonPropertyName("isUseLastDashDir_")]
    public bool IsUseLastDashDir { get; set; } = false;

    [JsonPropertyName("test_")]
    [Obsolete("Not exposed by the executable")]
    public BindingList<bool> Test { get; set; } = [];

    [JsonPropertyName("targetPosBbKey_")]
    [Obsolete("Not exposed by the executable")]
    public string TargetPosBbKey { get; set; }

    [JsonPropertyName("rotRate_")]
    [Obsolete("Not exposed by the executable")]
    public float RotRate { get; set; }
}
