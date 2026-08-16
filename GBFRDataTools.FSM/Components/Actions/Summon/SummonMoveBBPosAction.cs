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
public class SummonMoveBBPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonMoveBBPosAction);

    [JsonPropertyName("targetBBName_")]
    public string TargetBBName { get; set; }

    [JsonPropertyName("homingBBName_")]
    public string HomingBBName { get; set; }

    [JsonPropertyName("isApplyUnitOffset_")]
    public bool IsApplyUnitOffset { get; set; } = true;

    [JsonPropertyName("isUpdateCalc_")]
    public bool IsUpdateCalc { get; set; } = false;

    [JsonPropertyName("isApplyRotOnly_")]
    public bool IsApplyRotOnly { get; set; } = false;

    [JsonPropertyName("applyOffsetFromHoming_")]
    public bool ApplyOffsetFromHoming { get; set; } = false;
}
