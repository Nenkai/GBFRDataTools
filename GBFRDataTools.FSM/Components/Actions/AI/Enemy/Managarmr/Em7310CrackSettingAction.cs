using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7310CrackSettingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7310CrackSettingAction);

    [JsonPropertyName("param_")]
    public Em7310Crack_Param Param { get; set; } = new();
}

[TypeConverter(typeof(ExpandableObjectConverter))]
public class Em7310Crack_Param // Em7310Crack::Param
{
    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; } = 2.0f;

    [JsonPropertyName("impactTime_")]
    public float ImpactTime { get; set; } = 0.2f;

    [JsonPropertyName("impactAttackRate_")]
    public float ImpactAttackRate { get; set; } = 2.0f;

    [JsonPropertyName("impactBreakRate_")]
    public float ImpactBreakRate { get; set; } = 2.0f;

    [JsonPropertyName("impactHeight_")]
    public float ImpactHeight { get; set; } = 5.0f;

    [JsonPropertyName("impactHitStop_")]
    public float ImpactHitStop { get; set; } = 0.2f;

    [JsonPropertyName("crackUpdateTime_")]
    public float CrackUpdateTime { get; set; } = 1.0f;

    [JsonPropertyName("crackAttackRate_")]
    public float CrackAttackRate { get; set; } = 0.5f;

    [JsonPropertyName("crackBreakRate_")]
    public float CrackBreakRate { get; set; } = 0.5f;

    [JsonPropertyName("crackHeight_")]
    public float CrackHeight { get; set; } = 0.5f;

    [JsonPropertyName("crackHitStop_")]
    public float CrackHitStop { get; set; } = 0.0f;

    [JsonPropertyName("lineLength_")]
    public float LineLength { get; set; } = 20.0f;

    [JsonPropertyName("lineWidth_")]
    public float LineWidth { get; set; } = 5.0f;

    [JsonPropertyName("hexRadius_")]
    public float HexRadius { get; set; } = 10.0f;

    [JsonPropertyName("hexWidth_")]
    public float HexWidth { get; set; } = 2.0f;

    [JsonPropertyName("attackSub_")]
    public float AttackSub { get; set; } = 1.0f;
}