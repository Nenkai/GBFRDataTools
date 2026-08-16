using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ElementCoreBattleCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ElementCoreBattleCondition);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0;
}