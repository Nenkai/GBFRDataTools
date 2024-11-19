using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionScaleAction : ActionComponent
{
    [JsonPropertyName("scaleStart_")]
    public float ScaleStart { get; set; }

    [JsonPropertyName("scaleEnd_")]
    public float ScaleEnd { get; set; }

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; }

    [JsonPropertyName("changeSec_")]
    public float ChangeSec { get; set; }

    [JsonPropertyName("isChangeCollision_")]
    public bool IsChangeCollision { get; set; }

    [JsonPropertyName("isChangeObjHit_")]
    public bool IsChangeObjHit { get; set; }

    [JsonPropertyName("isDisableCollision_")]
    public bool IsDisableCollision { get; set; }

    [JsonPropertyName("isDisableObjHit_")]
    public bool IsDisableObjHit { get; set; }
}
