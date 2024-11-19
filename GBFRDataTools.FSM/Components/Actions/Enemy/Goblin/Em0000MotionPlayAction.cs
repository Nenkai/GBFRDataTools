using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Goblin;

public class Em0000MotionPlayAction : ActionComponent
{
    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; }

    [JsonPropertyName("isSetHomingParam_")]
    public bool IsSetHomingParam { get; set; }

    [JsonPropertyName("homingMaxAngle_")]
    public float HomingMaxAngle { get; set; }

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; }

    [JsonPropertyName("targetHomingType_")]
    public int TargetHomingType { get; set; }

    [JsonPropertyName("loop_")]
    public bool Loop { get; set; }
}
