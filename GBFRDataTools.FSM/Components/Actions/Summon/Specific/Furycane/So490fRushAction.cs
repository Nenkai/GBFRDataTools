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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Furycane;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So490fRushAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So490fRushAction);

    [JsonPropertyName("autoTurnTime_")]
    public float AutoTurnTime { get; set; } = 1.5f;

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; }

    [JsonPropertyName("fsmInfix_")]
    public string FsmInfix { get; set; }

    [JsonPropertyName("turnRatePrep_")]
    public float TurnRatePrep { get; set; } = 0.1f;

    [JsonPropertyName("turnRateRush_")]
    public float TurnRateRush { get; set; } = 0.1f;

    [JsonPropertyName("turnRateSlash_")]
    public float TurnRateSlash { get; set; } = 0.1f;

    [JsonPropertyName("maxTurnAngle_")]
    public float MaxTurnAngle { get; set; } = 30f;

    [JsonPropertyName("turnDeg_")]
    public float TurnDeg { get; set; } = 0.3f;

    [JsonPropertyName("offsetPos_")]
    public BindingList<Vector4> OffsetPos { get; set; } = [.. Enumerable.Repeat(Vector4.UnitW, 3)]; // std::array<Hw::cVec4,3>

    [JsonPropertyName("targetValidDeg_")]
    public float TargetValidDeg { get; set; } = 120f;

    [JsonPropertyName("targetValidLength_")]
    public float TargetValidLength { get; set; } = 30f;

    [JsonPropertyName("tornadeWaitTime_")]
    public float TornadeWaitTime { get; set; } = 1.5f;

    [JsonPropertyName("targetRangeType_")]
    public int TargetRangeType { get; set; } = 0;

    [JsonPropertyName("isSequenceOnly_")]
    public bool IsSequenceOnly { get; set; } = false;

    [JsonPropertyName("isTimeTurn_")]
    public bool IsTimeTurn { get; set; } = false;

    [JsonPropertyName("tornadeCameraOffsetPos_")]
    public Vector4 TornadeCameraOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("tornadeCameraDist_")]
    public float TornadeCameraDist { get; set; } = 10f;

    [JsonPropertyName("turnRateIdle_")]
    public float TurnRateIdle { get; set; } = 0.1f;

    [JsonPropertyName("signSize_")]
    public Vector4 SignSize { get; set; } = Vector4.UnitW;

    [JsonPropertyName("signPosOffset_")]
    public Vector4 SignPosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUpdateAttach_")]
    public bool IsUpdateAttach { get; set; } = true;

    [JsonPropertyName("isCreateSign_")]
    public bool IsCreateSign { get; set; } = true;

    [JsonPropertyName("blendMotionAddRate_")]
    public float BlendMotionAddRate { get; set; } = 0.02f;

    [JsonPropertyName("isControlOnLock_")]
    public bool IsControlOnLock { get; set; } = false;

    [JsonPropertyName("excludeDeg_")]
    public float ExcludeDeg { get; set; } = 5f;

    [JsonPropertyName("lockOnTurnDegIdle_")]
    public float LockOnTurnDegIdle { get; set; } = 1f;

    [JsonPropertyName("lockOnTurnDegPrep_")]
    public float LockOnTurnDegPrep { get; set; } = 1f;

    [JsonPropertyName("lockOnTurnDegRush_")]
    public float LockOnTurnDegRush { get; set; } = 1f;

    [JsonPropertyName("lockOnTurnDegSlash_")]
    public float LockOnTurnDegSlash { get; set; } = 1f;

    [JsonPropertyName("lockOnTurnDegTornade_")]
    public float LockOnTurnDegTornade { get; set; } = 1f;

    [JsonPropertyName("rushCameraOffsetPos_")]
    public Vector4 RushCameraOffsetPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isFixed_")]
    public bool IsFixed { get; set; } = true;

    [JsonPropertyName("cameraOffsetDegree_")]
    public Vector2 CameraOffsetDegree { get; set; } = Vector2.Zero;

    [JsonPropertyName("useSequenceNo_")]
    public int UseSequenceNo { get; set; } = 0;

    [JsonPropertyName("isTurnStopAttackCancel_")]
    public bool IsTurnStopAttackCancel { get; set; } = true;

    [JsonPropertyName("isStopAttackCancel_")]
    public bool IsStopAttackCancel { get; set; } = true;

    [JsonPropertyName("isEmHitStopAttackCancel_")]
    public bool IsEmHitStopAttackCancel { get; set; } = true;

    [JsonPropertyName("turnAngleOffset_")]
    public float TurnAngleOffset { get; set; } = 0f;

    [JsonPropertyName("interCompleteSec_")]
    public float InterCompleteSec { get; set; } = 0.05f;
}
