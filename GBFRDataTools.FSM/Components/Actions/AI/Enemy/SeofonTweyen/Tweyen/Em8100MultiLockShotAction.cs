using GBFRDataTools.Entities;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SeofonTweyen.Tweyen;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8100MultiLockShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100MultiLockShotAction);

    [JsonPropertyName("motionId_")]
    public string MotionId { get; set; } = "2500";

    [JsonPropertyName("shotBulletNum_")]
    public int ShotBulletNum { get; set; } = 5;

    [JsonPropertyName("shotRapidIntervalSec_")]
    public float ShotRapidIntervalSec { get; set; } = 0.2f;

    [JsonPropertyName("gravity_")]
    public float Gravity { get; set; } = 0.001f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f;

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = -0.06f;

    [JsonPropertyName("fsmShotFsmName_")]
    public string FsmShotFsmName { get; set; } = "multi_lock_shot";

    [JsonPropertyName("shotPosOffsetList_")]
    public BindingList<Vector4> ShotPosOffsetList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("shotOffsetRotXRad_")]
    public float ShotOffsetRotXRad { get; set; } = 15f;

    [JsonPropertyName("followArrowAttackSignSec_")]
    public float FollowArrowAttackSignSec { get; set; } = 1.5f;

    [JsonPropertyName("animHeightMoveRate_")]
    public float AnimHeightMoveRate { get; set; } = 1.5f;

    [JsonPropertyName("shotSplitIntervalFrame_")]
    public int ShotSplitIntervalFrame { get; set; } = 45;

    [JsonPropertyName("shotMoveStartDelayFrame_")]
    public int ShotMoveStartDelayFrame { get; set; } = 15;

    [JsonPropertyName("isHLMode_")]
    public bool IsHLMode { get; set; } = false;
}