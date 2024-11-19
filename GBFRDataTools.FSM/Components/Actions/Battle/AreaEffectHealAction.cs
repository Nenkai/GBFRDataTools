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
    public int Target { get; set; }

    [JsonPropertyName("healAmount_")]
    public float HealAmount { get; set; }

    [JsonPropertyName("deleySecond_")]
    public float DeleySecond { get; set; }

    [JsonPropertyName("lifeSecond_")]
    public float LifeSecond { get; set; }

    [JsonPropertyName("areaRadius_")]
    public float AreaRadius { get; set; }

    [JsonPropertyName("intervalSecond_")]
    public float IntervalSecond { get; set; }

    [JsonPropertyName("isContinue_")]
    public bool IsContinue { get; set; }

    [JsonPropertyName("disableAddIndirectDamage_")]
    public bool DisableAddIndirectDamage { get; set; }

    [JsonPropertyName("healLimit_")]
    public float HealLimit { get; set; }
}
