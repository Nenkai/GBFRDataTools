using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectHealAction : ActionComponent
{
    [JsonPropertyName("target_")]
    public int Target { get; set; } = 0;

    [JsonPropertyName("healAmount_")]
    public float HealAmount { get; set; } = 100.0f;

    [JsonPropertyName("deleySecond_")]
    public float DeleySecond { get; set; } = 0.0f;

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; } = 0.0f;

    [JsonPropertyName("areaRadius_")]
    public float AreaRadius { get; set; } = 5.0f;

    [JsonPropertyName("intervalSecond_")]
    public float IntervalSecond { get; set; } = 0.0f;

    [JsonPropertyName("isContinue_")]
    public bool IsContinue { get; set; } = false;

    [JsonPropertyName("disableAddIndirectDamage_")]
    public bool DisableAddIndirectDamage { get; set; } = false;

    [JsonPropertyName("healLimit_")]
    public float HealLimit { get; set; } = 99999.0f;
}
