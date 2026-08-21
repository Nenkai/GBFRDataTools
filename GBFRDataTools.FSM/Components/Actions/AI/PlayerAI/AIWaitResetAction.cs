using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AIWaitResetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIWaitResetAction);

    [JsonPropertyName("abilitySlot_")]
    public int AbilitySlot { get; set; } = 0;

    public override string? GetCaption()
    {
        return $"AbilitySlot: {AbilitySlot}";
    }
}
