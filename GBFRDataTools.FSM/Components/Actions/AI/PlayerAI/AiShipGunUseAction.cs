using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

public class AiShipGunUseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiShipGunUseAction);

    [Obsolete("Not used by the game")]
    [JsonPropertyName("state_")]
    public int State { get; set; }
}
