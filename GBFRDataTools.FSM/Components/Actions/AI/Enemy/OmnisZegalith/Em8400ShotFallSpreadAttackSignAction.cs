using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable")]
public class Em8400ShotFallSpreadAttackSignAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotFallSpreadAttackSignAction);

    [JsonPropertyName("attackSignSec_")]
    public float AttackSignSec { get; set; }

    [JsonPropertyName("attackSignCircleRadius_")]
    public float AttackSignCircleRadius { get; set; }

    [JsonPropertyName("attackSignRingRadius_")]
    public float AttackSignRingRadius { get; set; }

    [JsonPropertyName("homingSec_")]
    public float HomingSec { get; set; }
}