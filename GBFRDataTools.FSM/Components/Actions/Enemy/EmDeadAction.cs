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

public class EmDeadAction : ActionComponent
{
    [JsonPropertyName("motionIdNameDead_")]
    public string MotionIdNameDead { get; set; }

    [JsonPropertyName("isDeadExplode")]
    public bool IsDeadExplode { get; set; }

    [JsonPropertyName("IsInterpMotion_")]
    public bool IsInterpMotion { get; set; }
}
