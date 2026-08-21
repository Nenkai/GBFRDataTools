using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIBattleLinkAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleLinkAttackAction);

    [JsonPropertyName("isRapid_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsRapid { get; set; } = false;

    [JsonPropertyName("rapidEndTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float RapidEndTime { get; set; } = 0f;

    [JsonPropertyName("rapidIntervalTime_")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float RapidIntervalTime { get; set; } = 0f;

    public override string? GetCaption()
    {
        return $"IsRapid: {IsRapid} (EndTime: {RapidEndTime:F2}, Interval: {RapidIntervalTime:F2})";
    }
}
