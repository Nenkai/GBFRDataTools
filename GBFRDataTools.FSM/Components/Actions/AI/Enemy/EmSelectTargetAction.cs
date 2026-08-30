using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmSelectTargetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmSelectTargetAction);

    [JsonPropertyName("targetType_")]
    public int TargetType { get; set; } = 1;

    [JsonPropertyName("boolName_")]
    public string? BoolName { get; set; }
}