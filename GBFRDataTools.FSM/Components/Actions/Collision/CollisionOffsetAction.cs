using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionOffsetAction : ActionComponent
{
    [JsonPropertyName("nextOffset_")]
    public cVec4 NextOffset { get; set; }

    [JsonPropertyName("nextPartsNo_")]
    public int NextPartsNo { get; set; }

    [JsonPropertyName("nextRadius_")]
    public float NextRadius { get; set; }

    [JsonPropertyName("isRevert_")]
    public bool IsRevert { get; set; }
}
