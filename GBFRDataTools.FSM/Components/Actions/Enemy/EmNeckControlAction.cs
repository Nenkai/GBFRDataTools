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

public class EmNeckControlAction : ActionComponent
{
    [JsonPropertyName("isEnable_")]
    public bool IsEnable { get; set; } = false;

    [JsonPropertyName("isEndEnable_")]
    public bool IsEndEnable { get; set; } = false;

    [JsonPropertyName("isClearAngle_")]
    public bool IsClearAngle { get; set; } = false;
}
