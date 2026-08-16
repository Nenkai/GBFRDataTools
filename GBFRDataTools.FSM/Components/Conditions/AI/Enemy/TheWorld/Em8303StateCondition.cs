using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8303StateCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8303StateCondition);

    [JsonPropertyName("isNormalState_")]
    public bool IsNormalState { get; set; } = false;

    [JsonPropertyName("isDealState_")]
    public bool IsDealState { get; set; } = false;

    [JsonPropertyName("isStoreState_")]
    public bool IsStoreState { get; set; } = false;

    [JsonPropertyName("isCutinStoreState_")]
    public bool IsCutinStoreState { get; set; } = false;

    [JsonPropertyName("isSpartsCutinState_")]
    public bool IsSpartsCutinState { get; set; } = false; 

    [JsonPropertyName("isSpartsWaitState_")]
    public bool IsSpartsWaitState { get; set; } = false;

    [JsonPropertyName("isSummonState_")]
    public bool IsSummonState { get; set; } = false;

    [JsonPropertyName("isHomingState_")]
    public bool IsHomingState { get; set; } = false;
}