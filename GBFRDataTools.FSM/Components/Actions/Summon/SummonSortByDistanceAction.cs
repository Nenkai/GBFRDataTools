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
public class SummonSortByDistanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSortByDistanceAction);

    [JsonPropertyName("orderBlackBoard_")]
    public string OrderBlackBoard { get; set; }
}
