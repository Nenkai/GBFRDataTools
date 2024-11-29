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
    public string RightFrontMotionNameId { get; set; } = "0000";

    [JsonPropertyName("rightBackMotionNameId_")]
    public string RightBackMotionNameId { get; set; } = "0000";

    [JsonPropertyName("rightRideMotionNameId_")]
    public string RightRideMotionNameId { get; set; } = "0000";

    [JsonPropertyName("leftFrontMotionNameId_")]
    public string LeftFrontMotionNameId { get; set; } = "0000";

    [JsonPropertyName("leftBackMotionNameId_")]
    public string LeftBackMotionNameId { get; set; } = "0000";

    [JsonPropertyName("leftRideMotionNameId_")]
    public string LeftRideMotionNameId { get; set; } = "0000";

    [JsonPropertyName("isAdjustRightFront_")]
    public bool IsAdjustRightFront { get; set; } = true;

    [JsonPropertyName("isAdjustRightBack_")]
    public bool IsAdjustRightBack { get; set; } = true;

    [JsonPropertyName("isAdjustRightRide_")]
    public bool IsAdjustRightRide { get; set; } = true;

    [JsonPropertyName("isAdjustLeftFront_")]
    public bool IsAdjustLeftFront { get; set; } = true;

    [JsonPropertyName("isAdjustLeftBack_")]
    public bool IsAdjustLeftBack { get; set; } = true;

    [JsonPropertyName("isAdjustLeftRide_")]
    public bool IsAdjustLeftRide { get; set; } = true;

    [JsonPropertyName("isGrancypherHitSeTrigger_")]
    public bool IsGrancypherHitSeTrigger { get; set; } = false;

    [JsonPropertyName("isStartVyrnVoice_")]
    public bool IsStartVyrnVoice { get; set; } = true;

}
