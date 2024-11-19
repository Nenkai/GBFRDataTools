using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class NpcTurnToManualPlayerAction : ActionComponent
{
    [JsonPropertyName("rightMotionId_")]
    public string RightMotionId { get; set; }

    [JsonPropertyName("leftMotionId_")]
    public string LeftMotionId { get; set; }

    [JsonPropertyName("rightBackMotionId_")]
    public string RightBackMotionId { get; set; }

    [JsonPropertyName("leftBackMotionId_")]
    public string LeftBackMotionId { get; set; }

    [JsonPropertyName("endMotionId_")]
    public string EndMotionId { get; set; }
}
