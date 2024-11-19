using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class AiShipGunUseAction : ActionComponent
{
    [Obsolete("Not used by the game")]
    [JsonPropertyName("state_")]
    public int State { get; set; }
}
