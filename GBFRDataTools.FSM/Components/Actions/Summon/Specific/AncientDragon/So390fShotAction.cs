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

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.AncientDragon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class So390fShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(So390fShotAction);

    [JsonPropertyName("blendMotionIdleAddRate_")]
    public float BlendMotionIdleAddRate { get; set; } = 0.01f;

    [JsonPropertyName("blendMotionShotAddRate_")]
    public float BlendMotionShotAddRate { get; set; } = 0.02f;

    [JsonPropertyName("degreeMax_")]
    public float DegreeMax { get; set; } = 45f;

    [JsonPropertyName("signSize_")]
    public Vector4 SignSize { get; set; } = Vector4.UnitW;

    [JsonPropertyName("signResize_")]
    public Vector4 SignResize { get; set; } = Vector4.UnitW;

    [JsonPropertyName("posOffset_")]
    public Vector4 PosOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isUpdateAttach_")]
    public bool IsUpdateAttach { get; set; } = true;

    [JsonPropertyName("isCreateSign_")]
    public bool IsCreateSign { get; set; } = false;

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; }

    [JsonPropertyName("fsmInfix_")]
    public string FsmInfix { get; set; }

    [JsonPropertyName("blendAnimShotLeft_")]
    public string BlendAnimShotLeft { get; set; }

    [JsonPropertyName("blendAnimShotCenter_")]
    public string BlendAnimShotCenter { get; set; }

    [JsonPropertyName("blendAnimShotRight_")]
    public string BlendAnimShotRight { get; set; }

    [JsonPropertyName("waitTimeSeconds_")]
    public float WaitTimeSeconds { get; set; } = 0.1f;

    [JsonPropertyName("isRapidShot_")]
    public bool IsRapidShot { get; set; } = false;

    [JsonPropertyName("seqNo_")]
    public int SeqNo { get; set; } = 0;

    [JsonPropertyName("isCreateShot_")]
    public bool IsCreateShot { get; set; } = true;

    [JsonPropertyName("turnSpeed_")]
    public float TurnSpeed { get; set; } = 0.1f;

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 1f;

    [JsonPropertyName("animInterSec_")]
    public float AnimInterSec { get; set; } = 0.2f;

    [JsonPropertyName("turnAnimInterSec_")]
    public float TurnAnimInterSec { get; set; } = 0.2f;

    [JsonPropertyName("isBlendAnimation_")]
    public bool IsBlendAnimation { get; set; } = true;

    [JsonPropertyName("isFanSign_")]
    public bool IsFanSign { get; set; } = false;

    [JsonPropertyName("signAddRate_")]
    public float SignAddRate { get; set; } = 0.02f;

    [JsonPropertyName("signShotAddRate_")]
    public float SignShotAddRate { get; set; } = 0.02f;

    [JsonPropertyName("turnOffsetDeg_")]
    public float TurnOffsetDeg { get; set; } = 0f;

    [JsonPropertyName("isBlur_")]
    public bool IsBlur { get; set; } = false;

    [JsonPropertyName("blurWidth_")]
    public float BlurWidth { get; set; } = 0f;

    [JsonPropertyName("isShotCalcNeckToMouth_")]
    public bool IsShotCalcNeckToMouth { get; set; } = true;

    [JsonPropertyName("rapidRotWidth_")]
    public float RapidRotWidth { get; set; } = 1f;

    [JsonPropertyName("autoTurnTime_")]
    public float AutoTurnTime { get; set; } = 0.5f;

    [JsonPropertyName("animSpeedRate_")]
    public float AnimSpeedRate { get; set; } = 1f;

    [JsonPropertyName("isShotSign_")]
    public bool IsShotSign { get; set; } = false;

    [JsonPropertyName("interCompleteSec_")]
    public float InterCompleteSec { get; set; } = 0.05f;

    [JsonPropertyName("shotMaxCount_")]
    public int ShotMaxCount { get; set; } = 0;

    [JsonPropertyName("isSignSave_")]
    public bool IsSignSave { get; set; } = false;
}
