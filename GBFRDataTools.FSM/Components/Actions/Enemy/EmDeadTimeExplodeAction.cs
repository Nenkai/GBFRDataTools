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

public class EmDeadTimeExplodeAction : ActionComponent
{
    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0.0f;

    [JsonPropertyName("presageSec_")]
    public float PresageSec { get; set; } = 0.5f;
}
