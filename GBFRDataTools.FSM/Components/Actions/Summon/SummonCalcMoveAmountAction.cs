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
public class SummonCalcMoveAmountAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonCalcMoveAmountAction);

    [JsonPropertyName("isIgnoreY_")]
    public bool IsIgnoreY { get; set; } = false;

    [JsonPropertyName("bbKey_")]
    public string BbKey { get; set; }
}
