using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000MotionPlayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000MotionPlayAction);

    [JsonPropertyName("motionIdName_")]
    public /* sys::String */ string MotionIdName { get; set; } = string.Empty;

    [JsonPropertyName("isSetHomingParam_")]
    public bool IsSetHomingParam { get; set; } = false;

    [JsonPropertyName("homingMaxAngle_")]
    public float HomingMaxAngle { get; set; } = 0.2f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.2f;

    [JsonPropertyName("targetHomingType_")]
    [Description("Something to do with hash 0x9EEB60E9 internally")]
    public int TargetHomingType { get; set; } = 1;

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; } = false;
}
