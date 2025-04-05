using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotMoveStraightAction : ShotMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotMoveStraightAction);

    [JsonPropertyName("gravityScale_")]
    public float GravityScale { get; set; } = 0.0f;

    [JsonPropertyName("isRotateFall_")]
    public bool IsRotateFall { get; set; } = false;
}
