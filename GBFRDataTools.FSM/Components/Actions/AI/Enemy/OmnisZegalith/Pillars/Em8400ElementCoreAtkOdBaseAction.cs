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
public class Em8400ElementCoreAtkOdBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreAtkOdBaseAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;

    [JsonPropertyName("attackIndex_")]
    public int AttackIndex { get; set; } = -1;

    [JsonPropertyName("posRotParamIndex_")]
    public int PosRotParamIndex { get; set; } = 0;
}
