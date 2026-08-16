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
public class SummonSpawnItemizedEnemyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonSpawnItemizedEnemyAction);

    [JsonPropertyName("offsetFront_")]
    public float OffsetFront { get; set; } = 1f;

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; } = 3.5f;

    [JsonPropertyName("effectObjId_")]
    public int EffectObjId { get; set; } = -1;

    [JsonPropertyName("isHitEnemy_")]
    public bool IsHitEnemy { get; set; } = false;

    [JsonPropertyName("isFlameSeed_")]
    public bool IsFlameSeed { get; set; } = false;
}
