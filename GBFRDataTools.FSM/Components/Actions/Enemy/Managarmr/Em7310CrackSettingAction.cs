using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.Managarmr;

public class Em7310CrackSettingAction : ActionComponent
{
    [JsonPropertyName("param_")]
    public Em7310Crack_Param Param { get; set; }
}

public class Em7310Crack_Param // Em7310Crack::Param
{
    [JsonPropertyName("attackSignTime_")]
    public float AttackSignTime { get; set; }

    [JsonPropertyName("impactTime_")]
    public float ImpactTime { get; set; }

    [JsonPropertyName("impactAttackRate_")]
    public float ImpactAttackRate { get; set; }

    [JsonPropertyName("impactBreakRate_")]
    public float ImpactBreakRate { get; set; }

    [JsonPropertyName("impactHeight_")]
    public float ImpactHeight { get; set; }

    [JsonPropertyName("impactHitStop_")]
    public float ImpactHitStop { get; set; }

    [JsonPropertyName("crackUpdateTime_")]
    public float CrackUpdateTime { get; set; }

    [JsonPropertyName("crackAttackRate_")]
    public float CrackAttackRate { get; set; }

    [JsonPropertyName("crackBreakRate_")]
    public float CrackBreakRate { get; set; }

    [JsonPropertyName("crackHeight_")]
    public float CrackHeight { get; set; }

    [JsonPropertyName("crackHitStop_")]
    public float CrackHitStop { get; set; }

    [JsonPropertyName("lineLength_")]
    public float LineLength { get; set; }

    [JsonPropertyName("lineWidth_")]
    public float LineWidth { get; set; }

    [JsonPropertyName("hexRadius_")]
    public float HexRadius { get; set; }

    [JsonPropertyName("hexWidth_")]
    public float HexWidth { get; set; }

    [JsonPropertyName("attackSub_")]
    public float AttackSub { get; set; }
}