using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Actions.Player;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001SetAnimAdjustPosValueAction : MotionPlayAction
{
    [JsonPropertyName("rightFrontPosParam_")]
    public Em7001PositionParam RightFrontPosParam { get; set; }

    [JsonPropertyName("rightBackPosParam_")]
    public Em7001PositionParam RightBackPosParam { get; set; }

    [JsonPropertyName("rightRidePosParam_")]
    public Em7001PositionParam RightRidePosParam { get; set; }

    [JsonPropertyName("leftFrontPosParam_")]
    public Em7001PositionParam LeftFrontPosParam { get; set; }

    [JsonPropertyName("leftBackPosParam_")]
    public Em7001PositionParam LeftBackPosParam { get; set; }

    [JsonPropertyName("leftRidePosParam_")]
    public Em7001PositionParam LeftRidePosParam { get; set; }

    [JsonPropertyName("isSetRightFront_")]
    public bool IsSetRightFront { get; set; }

    [JsonPropertyName("isSetRightBack_")]
    public bool IsSetRightBack { get; set; }

    [JsonPropertyName("isSetRightRide_")]
    public bool IsSetRightRide { get; set; }

    [JsonPropertyName("isSetLeftFront_")]
    public bool IsSetLeftFront { get; set; }

    [JsonPropertyName("isSetLeftBack_")]
    public bool IsSetLeftBack { get; set; }

    [JsonPropertyName("isSetLeftRide_")]
    public bool IsSetLeftRide { get; set; }

}

public class Em7001PositionParam
{
    [JsonPropertyName("pos_")]
    public cVec4 Pos { get; set; }
}