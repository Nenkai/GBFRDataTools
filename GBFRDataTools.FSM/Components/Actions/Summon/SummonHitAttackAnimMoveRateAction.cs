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
public class SummonHitAttackAnimMoveRateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonHitAttackAnimMoveRateAction);

    [JsonPropertyName("animMoveRate_")]
    public float AnimMoveRate { get; set; } = 0f;

    [JsonPropertyName("resetAttackNum_")]
    public int ResetAttackNum { get; set; } = 1;
}

