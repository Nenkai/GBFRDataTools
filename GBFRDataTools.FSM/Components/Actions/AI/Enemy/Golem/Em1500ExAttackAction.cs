using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em1500ExAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500ExAttackAction);

    [JsonPropertyName("loopCountMax_")]
    public int LoopCountMax { get; set; } = 3;

    [JsonPropertyName("endSec_")]
    public float EndSec { get; set; } = -1f;
}