using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.ProtoBahamut;

public class Em7001DamageMotionPlayAction : EmDamageMotionPlayAction
{
    [JsonPropertyName("rightFrontMotionNameId_")]
    public string RightFrontMotionNameId { get; set; }

    [JsonPropertyName("rightBackMotionNameId_")]
    public string RightBackMotionNameId { get; set; }

    [JsonPropertyName("rightRideMotionNameId_")]
    public string RightRideMotionNameId { get; set; }

    [JsonPropertyName("leftFrontMotionNameId_")]
    public string LeftFrontMotionNameId { get; set; }

    [JsonPropertyName("leftBackMotionNameId_")]
    public string LeftBackMotionNameId { get; set; }

    [JsonPropertyName("leftRideMotionNameId_")]
    public string LeftRideMotionNameId { get; set; }

    [JsonPropertyName("isAdjustRightFront_")]
    public bool IsAdjustRightFront { get; set; }

    [JsonPropertyName("isAdjustRightBack_")]
    public bool IsAdjustRightBack { get; set; }

    [JsonPropertyName("isAdjustRightRide_")]
    public bool IsAdjustRightRide { get; set; }

    [JsonPropertyName("isAdjustLeftFront_")]
    public bool IsAdjustLeftFront { get; set; }

    [JsonPropertyName("isAdjustLeftBack_")]
    public bool IsAdjustLeftBack { get; set; }

    [JsonPropertyName("isAdjustLeftRide_")]
    public bool IsAdjustLeftRide { get; set; }

    [JsonPropertyName("isGrancypherHitSeTrigger_")]
    public bool IsGrancypherHitSeTrigger { get; set; }

    [JsonPropertyName("isStartVyrnVoice_")]
    public bool IsStartVyrnVoice { get; set; }

}
