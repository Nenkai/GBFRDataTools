using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Input;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckAboveStickMoveCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckAboveStickMoveCondition);

    [JsonPropertyName("threshold_")]
    public Vector2 Threshold { get; set; } = Vector2.Zero;
}