using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmMovePassAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmMovePassAction);

    [JsonPropertyName("params_")]
    public BindingList<PassParam> Params { get; set; } = [];

    // UNUSED
    [JsonPropertyName("paramCount_")]
    [Obsolete("Unused by the game")]
    public int ParamCount { get; set; }

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 5.0f;

    [JsonPropertyName("rotSpeedPerFrame_")]
    public float RotSpeedPerFrame { get; set; } = 360.0f;

    [JsonPropertyName("groundCheckHeight_")]
    public float GroundCheckHeight { get; set; } = 1.0f;

    [JsonPropertyName("groundCheckOffsetY_")]
    public float GroundCheckOffsetY { get; set; } = 0.0f;

    [JsonPropertyName("groundAngleMax_")]
    public float GroundAngleMax { get; set; } = 50.0f;

    [JsonPropertyName("enableBlackBoardBoolName_")]
    public string EnableBlackBoardBoolName { get; set; } = string.Empty;

    // All unused
    [JsonPropertyName("param0_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param0 { get; set; } = new();

    [JsonPropertyName("param1_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param1 { get; set; } = new();

    [JsonPropertyName("param2_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param2 { get; set; } = new();

    [JsonPropertyName("param3_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param3 { get; set; } = new();

    [JsonPropertyName("param4_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param4 { get; set; } = new();

    [JsonPropertyName("param5_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param5 { get; set; } = new();

    [JsonPropertyName("param6_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param6 { get; set; } = new();

    [JsonPropertyName("param7_")]
    [Obsolete("Unused by the game")]
    [Description("Not used by the game")]
    public PassParam Param7 { get; set; } = new();

    [JsonPropertyName("isYAxisOnly_")]
    public bool IsYAxisOnly { get; set; } = false;

    [JsonPropertyName("isCheckGround_")]
    public bool IsCheckGround { get; set; } = false;

    [JsonPropertyName("isNoGroundUsePrevPos_")]
    public bool IsNoGroundUsePrevPos { get; set; } = true;

    [JsonPropertyName("isStartCurTransform_")]
    public bool IsStartCurTransform { get; set; } = false;

    [JsonPropertyName("enableMovePartNo900_")]
    public bool EnableMovePartNo900 { get; set; } = false;

    [JsonPropertyName("isAddAnimMoveZ_")]
    public bool IsAddAnimMoveZ { get; set; } = false;

    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class PassParam
    {
        [JsonPropertyName("pos_")]
        public /* cVec3 */ Vector3 Pos { get; set; } = Vector3.Zero;

        [JsonPropertyName("rot_")]
        public /* cVec3 */ Vector3 Rot { get; set; } = Vector3.Zero;

        [JsonPropertyName("animationName_")]
        public string AnimationName { get; set; } = "0000";

        [JsonPropertyName("animationStartSecond_")]
        public float AnimationStartSecond { get; set; } = 0.0f;

        [JsonPropertyName("animationSpeed_")]
        public float AnimationSpeed { get; set; } = 1.0f;

        [JsonPropertyName("animationInterpolateSecond_")]
        public float AnimationInterpolateSecond { get; set; } = -1.0f;

        [JsonPropertyName("length_")]
        public float Length { get; set; } = 0.0f;

        [JsonPropertyName("moveSpeedScale_")]
        public float MoveSpeedScale { get; set; } = 1.0f;

        [JsonPropertyName("frontMoveRotZ_")]
        public float FrontMoveRotZ { get; set; } = 0.0f;

        [JsonPropertyName("blackBoardSetRate_")]
        public float BlackBoardSetRate { get; set; } = 0.0f;

        [JsonPropertyName("isUseCurrentPos_")]
        public bool IsUseCurrentPos { get; set; } = false;

        [JsonPropertyName("isSetFrontMoveDirection_")]
        public bool IsSetFrontMoveDirection { get; set; } = true;

        [JsonPropertyName("isSetAnimation_")]
        public bool IsSetAnimation { get; set; } = false;

        [JsonPropertyName("isLoopAnimation_")]
        public bool IsLoopAnimation { get; set; } = true;

        [JsonPropertyName("isWaitAnimation_")]
        public bool IsWaitAnimation { get; set; } = false;

        [JsonPropertyName("isCancelSameAnimation_")]
        public bool IsCancelSameAnimation { get; set; } = false;

        [JsonPropertyName("isEnableManipulaterRot_")]
        public bool IsEnableManipulaterRot { get; set; } = true;

        [JsonPropertyName("isSetBoolBlackBoard_")]
        public bool IsSetBoolBlackBoard { get; set; } = false;

    }

}

