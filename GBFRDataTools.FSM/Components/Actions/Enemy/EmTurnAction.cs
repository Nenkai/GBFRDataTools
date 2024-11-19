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
    public string RightMotionId { get; set; }

    [JsonPropertyName("leftMotionId_")]
    public string LeftMotionId { get; set; }

    [JsonPropertyName("backMotionId_")]
    public string BackMotionId { get; set; }

    [JsonPropertyName("backAngle_")]
    public float BackAngle { get; set; }
}
