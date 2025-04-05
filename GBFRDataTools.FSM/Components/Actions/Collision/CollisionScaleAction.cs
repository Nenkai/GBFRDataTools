using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionScaleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CollisionScaleAction);

    [JsonPropertyName("scaleStart_")]
    public float ScaleStart { get; set; } = 0.0f;

    [JsonPropertyName("scaleEnd_")]
    public float ScaleEnd { get; set; } = 1.0f;

    [JsonPropertyName("waitSec_")]
    public float WaitSec { get; set; } = 0.0f;

    [JsonPropertyName("changeSec_")]
    public float ChangeSec { get; set; } = 3.0f;

    [JsonPropertyName("isChangeCollision_")]
    public bool IsChangeCollision { get; set; } = true;

    [JsonPropertyName("isChangeObjHit_")]
    public bool IsChangeObjHit { get; set; } = false;

    [JsonPropertyName("isDisableCollision_")]
    public bool IsDisableCollision { get; set; } = false;

    [JsonPropertyName("isDisableObjHit_")]
    public bool IsDisableObjHit { get; set; } = false;
}
