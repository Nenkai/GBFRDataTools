using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em7700AtkExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkExAttackAction);

    [JsonPropertyName("isPowerUp_")]
    public bool IsPowerUp { get; set; } = false;

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0;

    [JsonPropertyName("delayType_")]
    public int DelayType { get; set; } = 0;
}

