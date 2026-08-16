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
public class Em8100SpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100SpecialArtsAction);

    [JsonPropertyName("shotIntervalSec_")]
    public float ShotIntervalSec { get; set; } = 0.1f;

    [JsonPropertyName("cutinOffsetRotY_")]
    public float CutinOffsetRotY { get; set; } = 0f;

    [JsonPropertyName("cutinOffsetRotYByHL_")]
    public float CutinOffsetRotYByHL { get; set; } = 0f;

    [JsonPropertyName("cutinStartIntervalSec_")]
    public float CutinStartIntervalSec { get; set; } = 1.5f;

    [JsonPropertyName("shotPosDistance_")]
    public float ShotPosDistance { get; set; } = 2.5f;

    [JsonPropertyName("shotPosRandamOffsetValue_")]
    public float ShotPosRandamOffsetValue { get; set; } = 1f;

    [JsonPropertyName("shotStartDelaySec_")]
    public float ShotStartDelaySec { get; set; } = 1.5f;

    [JsonPropertyName("attackSec_")]
    public float AttackSec { get; set; } = 1f;

    [JsonPropertyName("cutinMotionIdList_")]
    public BindingList<string> CutinMotionIdList { get; set; } = []; // std::vector<std::basic_string>

    [JsonPropertyName("shotFsmName_")]
    public string ShotFsmName { get; set; }

    [JsonPropertyName("readyMotionLoopTimeSec_")]
    public float ReadyMotionLoopTimeSec { get; set; } = 0.8f;

    [JsonPropertyName("shotMotionLoopTimeSec_")]
    public float ShotMotionLoopTimeSec { get; set; } = 7.5f;

    [JsonPropertyName("shotRandamSplitNum_")]
    public int ShotRandamSplitNum { get; set; } = 5;

    [JsonPropertyName("attackPosOffset_")]
    public Vector4 AttackPosOffset { get; set; } = new Vector4(0f, 0f, -30f, 1f);

    [JsonPropertyName("bezierMoveOffsetPos_")]
    public BindingList<Vector4> BezierMoveOffsetPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 2)]; // std::array<Hw::cVec4,2>

    [JsonPropertyName("finishAttackSignSec_")]
    public float FinishAttackSignSec { get; set; } = 3f;

    [JsonPropertyName("finishAttackMaxMovementRange_")]
    public float FinishAttackMaxMovementRange { get; set; } = 5.5f;

    [JsonPropertyName("finishAttackSignSize_")]
    public float FinishAttackSignSize { get; set; } = 20f;

    [JsonPropertyName("finishAttackDelayTimeSec_")]
    public float FinishAttackDelayTimeSec { get; set; } = 6f;

    [JsonPropertyName("vanishMagicCircleMediumSmallTimeSec_")]
    public float VanishMagicCircleMediumSmallTimeSec { get; set; } = 9.6f;

    [JsonPropertyName("finishAttackScaleTimeSec_")]
    public float FinishAttackScaleTimeSec { get; set; } = 5f;

    [JsonPropertyName("hlFinishAttackOffsetDist_")]
    public float HlFinishAttackOffsetDist { get; set; } = 22f;

    [JsonPropertyName("hlSetRotY_")]
    public float HlSetRotY { get; set; } = 15f;

    [JsonPropertyName("shotPlayerSerchInterval_")]
    public float ShotPlayerSerchInterval { get; set; } = 1f;

    [JsonPropertyName("shotPlayerAnticipationInterval_")]
    public float ShotPlayerAnticipationInterval { get; set; } = 2f;

    [JsonPropertyName("isPlayOneOnOneCutIn_")]
    public bool IsPlayOneOnOneCutIn { get; set; } = false;
}