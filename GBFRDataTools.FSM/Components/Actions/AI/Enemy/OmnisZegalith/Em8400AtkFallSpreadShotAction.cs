using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkFallSpreadShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkFallSpreadShotAction);

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_fall_spread_plasma";

    [JsonPropertyName("fsmSpreadShotName_")]
    public string FsmSpreadShotName { get; set; } = "shot_spread_plasma";

    [JsonPropertyName("actionEndIntervalSec_")]
    public float ActionEndIntervalSec { get; set; } = 3f;

    [JsonPropertyName("homingTimeSec_")]
    public float HomingTimeSec { get; set; } = 1f;

    [JsonPropertyName("shotDelaySec_")]
    public float ShotDelaySec { get; set; } = 1f;

    [JsonPropertyName("attackSignTimeSec_")]
    public float AttackSignTimeSec { get; set; } = 2f;

    [JsonPropertyName("attackSignCircleRadius_")]
    public float AttackSignCircleRadius { get; set; } = 2f;

    [JsonPropertyName("attackSignRingRadius_")]
    public float AttackSignRingRadius { get; set; } = 5f;

    [JsonPropertyName("spreadShotNum_")]
    public int SpreadShotNum { get; set; } = 12;

    [JsonPropertyName("spreadShotBombDelayBaseSec_")]
    public float SpreadShotBombDelayBaseSec { get; set; } = 1.4f;

    [JsonPropertyName("spreadShotBombDelayFrame_")]
    public int SpreadShotBombDelayFrame { get; set; } = 3;

    [JsonPropertyName("spreadDelayTimeSec_")]
    public float SpreadDelayTimeSec { get; set; } = 0f;

    [JsonPropertyName("isRandomTargetMode_")]
    public bool IsRandomTargetMode { get; set; } = false;

    [JsonPropertyName("shotLandingFrame_")]
    public int ShotLandingFrame { get; set; } = 30;

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 1;

    [JsonPropertyName("nextShotDelayFrame_")]
    public int NextShotDelayFrame { get; set; } = 30;

    [JsonPropertyName("isPositionTargetMode_")]
    public bool IsPositionTargetMode { get; set; } = false;

    [JsonPropertyName("shotPosList_")]
    public BindingList<Vector4> ShotPosList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("startMotionId_")]
    public MotionParameter StartMotionId { get; set; } = new();

    [JsonPropertyName("endMotionId_")]
    public MotionParameter EndMotionId { get; set; } = new();

    public class MotionParameter /* Em8400AtkFallSpreadShotAction::MotionParameter */
    {
        [JsonPropertyName("motId_")]
        public string MotId { get; set; }
    
        [JsonPropertyName("isLoop_")]
        public bool IsLoop { get; set; }
    
        [JsonPropertyName("isSkipSameMotionPlay_")]
        public bool IsSkipSameMotionPlay { get; set; }
    }
}