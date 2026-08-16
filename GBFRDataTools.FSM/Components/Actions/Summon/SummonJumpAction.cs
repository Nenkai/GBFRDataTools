using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Components.Conditions.AI;

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
public class SummonJumpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonJumpAction);

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 1f;

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1f;

    [JsonPropertyName("disableCheckGroundSec_")]
    public float DisableCheckGroundSec { get; set; } = 0.2f;
}
