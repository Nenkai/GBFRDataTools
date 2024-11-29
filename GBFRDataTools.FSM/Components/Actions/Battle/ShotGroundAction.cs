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
    public float CheckHeight { get; set; } = 1.0f;

    [JsonPropertyName("groundOffsetY_")]
    public float GroundOffsetY { get; set; } = -1.0f;
}
