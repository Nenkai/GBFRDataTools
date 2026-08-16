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

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonSetRotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSetRotAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("bbRotKey_")]
    public string BbRotKey { get; set; }
}
