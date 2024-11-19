using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI;

public class PlayerRotResetAction : ShotHitBaseAction
{
    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; }
}
