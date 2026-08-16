using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkTemperanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkTemperanceAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.4f;

    [JsonPropertyName("attackLoopTime_")]
    public float AttackLoopTime { get; set; } = 6f;

    [JsonPropertyName("verticalAttackIntervalMin_")]
    public float VerticalAttackIntervalMin { get; set; } = 0.2f;

    [JsonPropertyName("verticalAttackIntervalMax_")]
    public float VerticalAttackIntervalMax { get; set; } = 0.5f;

    [JsonPropertyName("horizontalAttackIntervalMin_")]
    public float HorizontalAttackIntervalMin { get; set; } = 0.5f;

    [JsonPropertyName("horizontalAttackIntervalMax_")]
    public float HorizontalAttackIntervalMax { get; set; } = 4f;

    [JsonPropertyName("areaSiza_")]
    public float AreaSiza { get; set; } = 35f;

    [JsonPropertyName("windTime_")]
    public float WindTime { get; set; } = 1f;
}