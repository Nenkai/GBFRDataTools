using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Player;

[GameSupport(GameVersion.EndlessRagnarok)]
[Description("Checks if the player is affected by a current status/debuff")]
public class PlayerStatusEffectCheckCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerStatusEffectCheckCondition);

    [JsonPropertyName("checkStatusEffectType_")]
    [Description("Status (debuff, etc) id")]
    public int CheckStatusEffectType { get; set; } = -1;

    [JsonPropertyName("checkLv_")]
    public int CheckLv { get; set; } = -1;

    [JsonPropertyName("isCheckMaxLv_")]
    public bool IsCheckMaxLv { get; set; } = false;

    [JsonPropertyName("isCheckLv_")]
    public bool IsCheckLv { get; set; } = false;
}