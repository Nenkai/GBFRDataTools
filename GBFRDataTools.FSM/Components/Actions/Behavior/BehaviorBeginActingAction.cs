using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorBeginActingAction : ActionComponent
{
    [JsonPropertyName("animationId_")]
    public string AnimationId { get; set; } = string.Empty;

    [JsonPropertyName("isAnimEnd_")]
    public bool IsAnimEnd { get; set; } = true;

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false;

    [JsonPropertyName("forceEndByBB_")]
    public bool ForceEndByBB { get; set; } = false;

    [JsonPropertyName("resetForceEndByBBAtEnd_")]
    public bool ResetForceEndByBBAtEnd { get; set; } = true;

    [JsonPropertyName("roundFrame_")]
    public bool RoundFrame { get; set; } = false;

    [JsonPropertyName("startFrame_")]
    public int StartFrame { get; set; } = -1;

    [JsonPropertyName("interFrame_")]
    public int InterFrame { get; set; } = -1;

    [JsonPropertyName("secondOfCorrectAnimationSpeed_")]
    public float SecondOfCorrectAnimationSpeed { get; set; } = 0.0f;

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; } = 1.0f;

    [JsonPropertyName("animationSlotNo_")]
    public int AnimationSlotNo { get; set; } = 0;

    [JsonPropertyName("isCorrectTransform_")]
    public bool IsCorrectTransform { get; set; } = false;

    [JsonPropertyName("correctElement_")]
    public int CorrectElement { get; set; } = 0;

    [JsonPropertyName("targetPosition_")]
    public /* cVec4 */ Vector4 TargetPosition { get; set; } = Vector4.UnitW;

    [JsonPropertyName("targetRotation_")]
    public /* cVec4 */ Vector4 TargetRotation { get; set; } = Vector4.UnitW;

    [JsonPropertyName("correctTransformSecond_")]
    public float CorrectTransformSecond { get; set; } = 0.0f;

    [JsonPropertyName("easingType_")]
    public EasingType EasingType { get; set; } = EasingType.Type0;

    [JsonPropertyName("isEnableCameraAnimation_")]
    public bool IsEnableCameraAnimation { get; set; } = false;

    [JsonPropertyName("cameraAnimationUsageSecond_")]
    public float CameraAnimationUsageSecond { get; set; } = 0.0f;
}

public enum EasingType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
}