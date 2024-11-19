using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class BehaviorBeginActingAction : ActionComponent
{
    [JsonPropertyName("animationId_")]
    public string AnimationId { get; set; }

    [JsonPropertyName("isAnimEnd_")]
    public bool IsAnimEnd { get; set; }

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; }

    [JsonPropertyName("forceEndByBB_")]
    public bool ForceEndByBB { get; set; }

    [JsonPropertyName("resetForceEndByBBAtEnd_")]
    public bool ResetForceEndByBBAtEnd { get; set; }

    [JsonPropertyName("roundFrame_")]
    public bool RoundFrame { get; set; }

    [JsonPropertyName("startFrame_")]
    public int StartFrame { get; set; }

    [JsonPropertyName("interFrame_")]
    public int InterFrame { get; set; }

    [JsonPropertyName("secondOfCorrectAnimationSpeed_")]
    public float SecondOfCorrectAnimationSpeed { get; set; }

    [JsonPropertyName("speedRate_")]
    public float SpeedRate { get; set; }

    [JsonPropertyName("animationSlotNo_")]
    public int AnimationSlotNo { get; set; }

    [JsonPropertyName("isCorrectTransform_")]
    public bool IsCorrectTransform { get; set; }

    [JsonPropertyName("correctElement_")]
    public int CorrectElement { get; set; }

    [JsonPropertyName("targetPosition_")]
    public cVec4 TargetPosition { get; set; }

    [JsonPropertyName("targetRotation_")]
    public cVec4 TargetRotation { get; set; }

    [JsonPropertyName("correctTransformSecond_")]
    public float CorrectTransformSecond { get; set; }

    [JsonPropertyName("easingType_")]
    public EasingType EasingType { get; set; }

    [JsonPropertyName("isEnableCameraAnimation_")]
    public bool IsEnableCameraAnimation { get; set; }

    [JsonPropertyName("cameraAnimationUsageSecond_")]
    public float CameraAnimationUsageSecond { get; set; }
}

public enum EasingType
{
    Type0 = 0,
    Type1 = 1,
    Type2 = 2,
    Type3 = 3,
    Type4 = 4,
}