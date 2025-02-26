using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.Player;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001SetAnimAdjustPosValueAction : MotionPlayAction
{
    [JsonPropertyName("rightFrontPosParam_")]
    public Em7001PositionParam RightFrontPosParam { get; set; } = new();

    [JsonPropertyName("rightBackPosParam_")]
    public Em7001PositionParam RightBackPosParam { get; set; } = new();

    [JsonPropertyName("rightRidePosParam_")]
    public Em7001PositionParam RightRidePosParam { get; set; } = new();

    [JsonPropertyName("leftFrontPosParam_")]
    public Em7001PositionParam LeftFrontPosParam { get; set; } = new();

    [JsonPropertyName("leftBackPosParam_")]
    public Em7001PositionParam LeftBackPosParam { get; set; } = new();

    [JsonPropertyName("leftRidePosParam_")]
    public Em7001PositionParam LeftRidePosParam { get; set; } = new();

    [JsonPropertyName("isSetRightFront_")]
    public bool IsSetRightFront { get; set; } = true;

    [JsonPropertyName("isSetRightBack_")]
    public bool IsSetRightBack { get; set; } = true;

    [JsonPropertyName("isSetRightRide_")]
    public bool IsSetRightRide { get; set; } = true;

    [JsonPropertyName("isSetLeftFront_")]
    public bool IsSetLeftFront { get; set; } = true;

    [JsonPropertyName("isSetLeftBack_")]
    public bool IsSetLeftBack { get; set; } = true;

    [JsonPropertyName("isSetLeftRide_")]
    public bool IsSetLeftRide { get; set; } = true;

}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7001PositionParam
{
    [JsonPropertyName("pos_")]
    public /* cVec4 */ Vector4 Pos { get; set; } = Vector4.UnitW;
}