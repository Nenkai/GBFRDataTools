﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001DamageDownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001DamageDownAction);

    [JsonPropertyName("isInitDownReaction_")]
    public bool IsInitDownReaction { get; set; } = true;

    [JsonPropertyName("rightFrontMotionNameId_")]
    public string RightFrontMotionNameId { get; set; } = "b611";

    [JsonPropertyName("rightBackMotionNameId_")]
    public string RightBackMotionNameId { get; set; } = "b614";

    [JsonPropertyName("rightRideMotionNameId_")]
    public string RightRideMotionNameId { get; set; } = "b617";

    [JsonPropertyName("leftFrontMotionNameId_")]
    public string LeftFrontMotionNameId { get; set; } = "b631";

    [JsonPropertyName("leftBackMotionNameId_")]
    public string LeftBackMotionNameId { get; set; } = "b634";

    [JsonPropertyName("leftRideMotionNameId_")]
    public string LeftRideMotionNameId { get; set; } = "b637";

    [JsonPropertyName("isOverrideMotionId_")]
    public bool IsOverrideMotionId { get; set; } = false;
}
