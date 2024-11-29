using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy;

public class EmTurnAction : ActionComponent
{
    [JsonPropertyName("rightMotionId_")]
    public /* sys::String */ string RightMotionId { get; set; } = "0062";

    [JsonPropertyName("leftMotionId_")]
    public /* sys::String */ string LeftMotionId { get; set; } = "0063";

    [JsonPropertyName("backMotionId_")]
    public /* sys::String */ string BackMotionId { get; set; } = "0064";

    [JsonPropertyName("backAngle_")]
    public float BackAngle { get; set; } = 90.0f;
}
