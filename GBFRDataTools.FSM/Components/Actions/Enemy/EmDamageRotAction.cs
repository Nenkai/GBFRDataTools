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

public class EmDamageRotAction : ActionComponent
{
    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 1.0f;

    [JsonPropertyName("updateType_")]
    public EmDamageRotActionUpdateType UpdateType { get; set; } = 0;
}
