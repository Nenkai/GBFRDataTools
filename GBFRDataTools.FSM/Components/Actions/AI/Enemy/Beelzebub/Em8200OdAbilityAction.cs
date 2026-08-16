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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8200OdAbilityAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8200OdAbilityAction);

    [JsonPropertyName("bindTargetAngleLowerLimit_")]
    public float BindTargetAngleLowerLimit { get; set; } = -90f;

    [JsonPropertyName("bindTargetAngleUpperLimit_")]
    public float BindTargetAngleUpperLimit { get; set; } = 90f;
}