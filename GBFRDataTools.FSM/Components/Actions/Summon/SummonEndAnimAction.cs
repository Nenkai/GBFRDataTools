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
public class SummonEndAnimAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonEndAnimAction);

    [JsonPropertyName("animId_")]
    public int AnimId { get; set; } = -1;

    [JsonPropertyName("isUseDetailSetting_")]
    public bool IsUseDetailSetting { get; set; } = false;

    [JsonPropertyName("sequenceNumber_")]
    public int SequenceNumber { get; set; } = -1;

    [JsonPropertyName("isLoopAnim_")]
    public bool IsLoopAnim { get; set; } = false;

    [JsonPropertyName("animSpeed_")]
    public float AnimSpeed { get; set; } = 1f;

    [JsonPropertyName("animInterTime_")]
    public float AnimInterTime { get; set; } = 0.2f;
}
