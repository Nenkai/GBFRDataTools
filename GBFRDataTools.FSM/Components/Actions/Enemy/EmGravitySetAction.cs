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

public class EmGravitySetAction : ActionComponent
{
    [JsonPropertyName("gOptionIdx_")]
    public int GOptionIdx { get; set; } = 0;

    [JsonPropertyName("gOptionTiming_")]
    public int GOptionTiming { get; set; } = 0;

    [JsonPropertyName("isUndoEnd_")]
    public bool IsUndoEnd { get; set; } = false;
}
