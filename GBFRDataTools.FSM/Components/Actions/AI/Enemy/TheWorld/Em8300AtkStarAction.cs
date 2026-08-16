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
public class Em8300AtkStarAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkStarAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.4f;

    [JsonPropertyName("inhaleTime_")]
    public float InhaleTime { get; set; } = 10f;

    [JsonPropertyName("rushTime_")]
    public float RushTime { get; set; } = 10f;

    [JsonPropertyName("rushWaitTime_")]
    public float RushWaitTime { get; set; } = 1.5f;

    [JsonPropertyName("lightAttackTime_")]
    public float LightAttackTime { get; set; } = 0.01f;

    [JsonPropertyName("stopInhaleAttackTime")]
    public float StopInhaleAttackTime { get; set; } = 1f;

    [JsonPropertyName("inhaleAttackTime_")]
    public float InhaleAttackTime { get; set; } = 0f;

    [JsonPropertyName("attackRandomX_")]
    public float AttackRandomX { get; set; } = 5f;

    [JsonPropertyName("changeRotTime_")]
    public float ChangeRotTime { get; set; } = 1f;

    [JsonPropertyName("attackRandomAddRot_")]
    public float AttackRandomAddRot { get; set; } = 0.7853982f;

    [JsonPropertyName("attackRandomAddZ_")]
    public float AttackRandomAddZ { get; set; } = 9f;

    [JsonPropertyName("finishAttackNum_")]
    public int FinishAttackNum { get; set; } = 4;

    [JsonPropertyName("playerRandomAttackTime_")]
    public float PlayerRandomAttackTime { get; set; } = 1f;

    [JsonPropertyName("playerRandomAttackDelayTime_")]
    public float PlayerRandomAttackDelayTime { get; set; } = 0.5f;

    [JsonPropertyName("windTime_")]
    public float WindTime { get; set; } = 1f;
}