using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Simulates a link attack input from the player. 
    Requires a link attack window to be active.
    """)]
public class AIBattleLinkAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleLinkAttackAction);

    [JsonPropertyName("isRapid_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public bool IsRapid { get; set; } = false;

    [JsonPropertyName("rapidEndTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float RapidEndTime { get; set; } = 0f;

    [JsonPropertyName("rapidIntervalTime_")]
    [Description("Added in Endless Ragnarok")]
    [GameSupport(GameVersion.EndlessRagnarok)]
    public float RapidIntervalTime { get; set; } = 0f;
}
