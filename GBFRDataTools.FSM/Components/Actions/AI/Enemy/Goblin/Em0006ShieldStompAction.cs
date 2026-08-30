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
public class Em0006ShieldStompAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0006ShieldStompAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; }

    [JsonPropertyName("loopNum_")]
    public int LoopNum { get; set; }

    [JsonPropertyName("loopEndRange_")]
    public int LoopEndRange { get; set; }

    [JsonPropertyName("shieldDamage_")]
    public int ShieldDamage { get; set; }
}