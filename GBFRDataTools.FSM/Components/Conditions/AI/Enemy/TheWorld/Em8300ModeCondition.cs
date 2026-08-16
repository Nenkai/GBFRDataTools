using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300ModeCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300ModeCondition);

    [JsonPropertyName("isNormalMode_")]
    public bool IsNormalMode { get; set; } = false;

    [JsonPropertyName("isSphereMode_")]
    public bool IsSphereMode { get; set; } = false;

    [JsonPropertyName("isWingMode_")]
    public bool IsWingMode { get; set; } = false;
}