using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.Pillars;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreAtkSimpleOdBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreAtkSimpleOdBaseAction);

    [JsonPropertyName("isPowerUpMode_")]
    public bool IsPowerUpMode { get; set; } = false;

    [JsonPropertyName("isFinalPhaseMode_")]
    public bool IsFinalPhaseMode { get; set; } = false;

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 1f;
}
