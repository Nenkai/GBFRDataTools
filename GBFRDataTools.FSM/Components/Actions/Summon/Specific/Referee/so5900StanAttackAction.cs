using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon.Specific.Referee;

[GameSupport(GameVersion.EndlessRagnarok)]
#pragma warning disable IDE1006 // Naming Styles
public class so5900StanAttackAction : ActionComponent
#pragma warning restore IDE1006 // Naming Styles
{
    [JsonIgnore]
    public override string ComponentName => nameof(so5900StanAttackAction);

    [JsonPropertyName("fsmClassName_")]
    public string FsmClassName { get; set; }

    [JsonPropertyName("fsmInfixNearEnemy_")]
    public string FsmInfixNearEnemy { get; set; }

    [JsonPropertyName("fsmInfixFarEnemy_")]
    public string FsmInfixFarEnemy { get; set; }

    [JsonPropertyName("attackRadius_")]
    public float AttackRadius { get; set; } = 10f;

    [JsonPropertyName("attackHight_")]
    public float AttackHight { get; set; } = 5f;

    [JsonPropertyName("nearBreakRate_")]
    public float NearBreakRate { get; set; } = 50f;
}