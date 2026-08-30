using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable.")]
public class Em0006JumpStompAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0006JumpStompAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; }

    [JsonPropertyName("disableCheckGroundTimer_")]
    public float DisableCheckGroundTimer { get; set; }

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; }

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; }

    [JsonPropertyName("movementDist_")]
    public float MovementDist { get; set; }

    [JsonPropertyName("isComboAttack_")]
    public bool IsComboAttack { get; set; }

    [JsonPropertyName("shieldDamage_")]
    public int ShieldDamage { get; set; }
}