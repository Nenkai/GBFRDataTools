using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Collision;

public class CollisionOffsetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CollisionOffsetAction);

    [JsonPropertyName("nextOffset_")]
    public /* cVec4 */ Vector4 NextOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("nextPartsNo_")]
    public int NextPartsNo { get; set; } = -1;

    [JsonPropertyName("nextRadius_")]
    public float NextRadius { get; set; } = 1.0f;

    [JsonPropertyName("isRevert_")]
    public bool IsRevert { get; set; } = true;
}
