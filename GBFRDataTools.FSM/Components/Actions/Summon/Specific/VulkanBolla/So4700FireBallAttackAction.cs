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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.VulkanBolla;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So4700FireBallAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So4700FireBallAttackAction);

    [JsonPropertyName("loopMotionPlayCountMax_")]
    public int LoopMotionPlayCountMax { get; set; } = 1;

    [JsonPropertyName("frontMagmaAreaVanishSec_")]
    public float FrontMagmaAreaVanishSec { get; set; } = 8.85f;

    [JsonPropertyName("motionSpeedAdd_")]
    public float MotionSpeedAdd { get; set; } = 0.25f;

    [JsonPropertyName("attackSignOffsetL_")]
    public Vector4 AttackSignOffsetL { get; set; } = Vector4.UnitW;

    [JsonPropertyName("attackSignOffsetR_")]
    public Vector4 AttackSignOffsetR { get; set; } = Vector4.UnitW;

    [JsonPropertyName("attackSignCircleRadius_")]
    public float AttackSignCircleRadius { get; set; } = 5f;

    [JsonPropertyName("shotLaunchFrameL_")]
    public int ShotLaunchFrameL { get; set; } = 0;

    [JsonPropertyName("shotLaunchFrameR_")]
    public int ShotLaunchFrameR { get; set; } = 0;

    [JsonPropertyName("shotSpeed_")]
    public float ShotSpeed { get; set; } = 1f;

    [JsonPropertyName("shotFrontDegree_")]
    public float ShotFrontDegree { get; set; } = 0f;

    [JsonPropertyName("shotFrontLimitDegree_")]
    public float ShotFrontLimitDegree { get; set; } = 90f;

    [JsonPropertyName("shotGravityScale_")]
    public float ShotGravityScale { get; set; } = 1f;

    [JsonPropertyName("shotMoveSecMin_")]
    public float ShotMoveSecMin { get; set; } = 1f;

    [JsonPropertyName("shotCollisionRadius_")]
    public float ShotCollisionRadius { get; set; } = 3f;

    [JsonPropertyName("isDispCircleSign_")]
    public bool IsDispCircleSign { get; set; } = true;

    [JsonPropertyName("targetPosSyncIntervalSec_")]
    public float TargetPosSyncIntervalSec { get; set; } = 0.1f;
}
