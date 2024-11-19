
using GBFRDataTools.FSM.Components.Actions.Player;
using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotGroundAction : ShotHitBaseAction
{
    [JsonPropertyName("checkHeight_")]
    public float CheckHeight { get; set; }

    [JsonPropertyName("groundOffsetY_")]
    public float GroundOffsetY { get; set; }
}
