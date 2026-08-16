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
public class Em8100CombinationSpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8100CombinationSpecialArtsAction);

    [JsonPropertyName("baseDir_")]
    public float BaseDir { get; set; } = 0f;

    [JsonPropertyName("baseDirByHL_")]
    public float BaseDirByHL { get; set; } = 0f;

    [JsonPropertyName("motionMoveSpeedRate_")]
    public float MotionMoveSpeedRate { get; set; } = 4f;

    [JsonPropertyName("heightAdjustValue1stPhase_")]
    public float HeightAdjustValue1stPhase { get; set; } = 0.01f;

    [JsonPropertyName("heightAdjustValue2ndPhase_")]
    public float HeightAdjustValue2ndPhase { get; set; } = 0.025f;

    [JsonPropertyName("heightAdjustValue3rdPhase_")]
    public float HeightAdjustValue3rdPhase { get; set; } = 0.03f;

    [JsonPropertyName("startPositionOffset_")]
    public Vector4 StartPositionOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("startDelayTimeSec_")]
    public float StartDelayTimeSec { get; set; } = 1f;

    [JsonPropertyName("beamShootingTimeSec_")]
    public float BeamShootingTimeSec { get; set; } = 3f;

    [JsonPropertyName("beamShootingAttackSignTimeSec_")]
    public float BeamShootingAttackSignTimeSec { get; set; } = 3f;

    [JsonPropertyName("beamAttackSignOffsetWitdh_")]
    public float BeamAttackSignOffsetWitdh { get; set; } = 0.7f;

    [JsonPropertyName("beamShootingAttackRange_")]
    public float BeamShootingAttackRange { get; set; } = 200f;

    [JsonPropertyName("checkDistByMoveBeamPosition_")]
    public float CheckDistByMoveBeamPosition { get; set; } = 0.5f;

    [JsonPropertyName("beamShootPosList_")]
    public BindingList<Vector4> BeamShootPosList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("beamShootRotList_")]
    public BindingList<Vector4> BeamShootRotList { get; set; } = []; // std::vector<Hw::cVec4>

    [JsonPropertyName("laserParameterList_")]
    public BindingList<LaserParameter> LaserParameterList { get; set; } = []; // std::vector<std::vector<BT::Em8100CombinationSpecialArtsAction::LaserParameter>

    [JsonPropertyName("arrowRainShotPos_")]
    public Vector4 ArrowRainShotPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("arrowRainWaitLoopTimeSec_")]
    public float ArrowRainWaitLoopTimeSec { get; set; } = 0f;

    [JsonPropertyName("arrowRainStartDelaySec_")]
    public float ArrowRainStartDelaySec { get; set; } = 0.75f;

    [JsonPropertyName("arrowRainAttackTimeSec_")]
    public float ArrowRainAttackTimeSec { get; set; } = 120f;

    [JsonPropertyName("arrowRainWidthScaleTimeSec_")]
    public float ArrowRainWidthScaleTimeSec { get; set; } = 7f;

    [JsonPropertyName("arrowRainShotIntervalFrame_")]
    public int ArrowRainShotIntervalFrame { get; set; } = 6;

    [JsonPropertyName("stellaBeamVFXCallTimeSec_")]
    public float StellaBeamVFXCallTimeSec { get; set; } = 2.5f;

    [JsonPropertyName("stellaBeamWidth_")]
    public float StellaBeamWidth { get; set; } = 35f;

    [JsonPropertyName("stellaBeamAttackSignDelaySec_")]
    public float StellaBeamAttackSignDelaySec { get; set; } = 1.5f;

    [JsonPropertyName("stellaBeamAttackSignTimeSec_")]
    public float StellaBeamAttackSignTimeSec { get; set; } = 3f;

    [JsonPropertyName("stellaBeamAttackSignWidth_")]
    public float StellaBeamAttackSignWidth { get; set; } = 1f;

    [JsonPropertyName("stellaBeamAttackTimeSec_")]
    public float StellaBeamAttackTimeSec { get; set; } = 3f;

    [JsonPropertyName("actionEndPosition_")]
    public Vector4 ActionEndPosition { get; set; } = Vector4.UnitW;

    [JsonPropertyName("actionEndWaitLoopTimeSec_")]
    public float ActionEndWaitLoopTimeSec { get; set; } = 1f;

    [JsonPropertyName("multiWayBeamShotFsm_")]
    public string MultiWayBeamShotFsm { get; set; } = "combination_sparts_beam";

    [JsonPropertyName("arrowRainShotFsm_")]
    public string ArrowRainShotFsm { get; set; } = "combination_sparts_arrow_rain";

    [JsonPropertyName("wedgeSetNum_")]
    public int WedgeSetNum { get; set; } = 15;

    [JsonPropertyName("wedgeSetDistance_")]
    public float WedgeSetDistance { get; set; } = 15f;

    [JsonPropertyName("dpsCheckTimeSec_")]
    public float DpsCheckTimeSec { get; set; } = 30f;

    [JsonPropertyName("endFallMotionMovementRate_")]
    public float EndFallMotionMovementRate { get; set; } = 4.5f;

    public class LaserParameter /* Em8100CombinationSpecialArtsAction::LaserParameter */
    {
        [JsonPropertyName("size_")]
        public float Size { get; set; }
    
        [JsonPropertyName("dir_")]
        public float Dir { get; set; }
    
        [JsonPropertyName("offset_")]
        public Vector4 Offset { get; set; }
    
        [JsonPropertyName("shotRotX_")]
        public float ShotRotX { get; set; }
    
        [JsonPropertyName("attackSignOffsetDist_")]
        public float AttackSignOffsetDist { get; set; }
    
        [JsonPropertyName("burnMarksVFXRotY_")]
        public float BurnMarksVFXRotY { get; set; }
    
        [JsonPropertyName("burnMarksVFXOffset_")]
        public Vector4 BurnMarksVFXOffset { get; set; }
    }
}