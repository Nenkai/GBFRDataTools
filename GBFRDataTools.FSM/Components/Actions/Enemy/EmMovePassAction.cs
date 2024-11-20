using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmMovePassAction : ActionComponent
{
    [JsonPropertyName("params_")]
    public BindingList<EmMovePassAction_PassParam> Params { get; set; }

    // UNUSED
    [JsonPropertyName("paramCount_")]
    public int ParamCount { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; }

    [JsonPropertyName("rotSpeedPerFrame_")]
    public float RotSpeedPerFrame { get; set; }

    [JsonPropertyName("groundCheckHeight_")]
    public float GroundCheckHeight { get; set; }

    [JsonPropertyName("groundCheckOffsetY_")]
    public float GroundCheckOffsetY { get; set; }

    [JsonPropertyName("groundAngleMax_")]
    public float GroundAngleMax { get; set; }

    [JsonPropertyName("enableBlackBoardBoolName_")]
    public string EnableBlackBoardBoolName { get; set; }

    // All unused
    public EmMovePassAction_PassParam param0_ { get; set; }
    public EmMovePassAction_PassParam param1_ { get; set; }
    public EmMovePassAction_PassParam param2_ { get; set; }
    public EmMovePassAction_PassParam param3_ { get; set; }
    public EmMovePassAction_PassParam param4_ { get; set; }
    public EmMovePassAction_PassParam param5_ { get; set; }
    public EmMovePassAction_PassParam param6_ { get; set; }
    public EmMovePassAction_PassParam param7_ { get; set; }

    [JsonPropertyName("isYAxisOnly_")]
    public bool IsYAxisOnly { get; set; }

    [JsonPropertyName("isCheckGround_")]
    public bool IsCheckGround { get; set; }

    [JsonPropertyName("isNoGroundUsePrevPos_")]
    public bool IsNoGroundUsePrevPos { get; set; }

    [JsonPropertyName("isStartCurTransform_")]
    public bool IsStartCurTransform { get; set; }

    [JsonPropertyName("enableMovePartNo900_")]
    public bool EnableMovePartNo900 { get; set; }

    [JsonPropertyName("isAddAnimMoveZ_")]
    public bool IsAddAnimMoveZ { get; set; }
}

public class EmMovePassAction_PassParam
{
    [JsonPropertyName("pos_")]
    public cVec3 Pos { get; set; }
    
    [JsonPropertyName("rot_")]
    public cVec3 Rot { get; set; }
    
    [JsonPropertyName("animationName_")]
    public string AnimationName { get; set; }
    
    [JsonPropertyName("animationStartSecond_")]
    public float AnimationStartSecond { get; set; }
    
    [JsonPropertyName("animationSpeed_")]
    public float AnimationSpeed { get; set; }
    
    [JsonPropertyName("animationInterpolateSecond_")]
    public float AnimationInterpolateSecond { get; set; }
    
    [JsonPropertyName("length_")]
    public float Length { get; set; }
    
    [JsonPropertyName("moveSpeedScale_")]
    public float MoveSpeedScale { get; set; }
    
    [JsonPropertyName("frontMoveRotZ_")]
    public float FrontMoveRotZ { get; set; }
    
    [JsonPropertyName("blackBoardSetRate_")]
    public float BlackBoardSetRate { get; set; }
    
    [JsonPropertyName("isUseCurrentPos_")]
    public bool IsUseCurrentPos { get; set; }
    
    [JsonPropertyName("isSetFrontMoveDirection_")]
    public bool IsSetFrontMoveDirection { get; set; }
    
    [JsonPropertyName("isSetAnimation_")]
    public bool IsSetAnimation { get; set; }
    
    [JsonPropertyName("isLoopAnimation_")]
    public bool IsLoopAnimation { get; set; }
    
    [JsonPropertyName("isWaitAnimation_")]
    public bool IsWaitAnimation { get; set; }
    
    [JsonPropertyName("isCancelSameAnimation_")]
    public bool IsCancelSameAnimation { get; set; }
    
    [JsonPropertyName("isEnableManipulaterRot_")]
    public bool IsEnableManipulaterRot { get; set; }
    
    [JsonPropertyName("isSetBoolBlackBoard_")]
    public bool IsSetBoolBlackBoard { get; set; }

}
