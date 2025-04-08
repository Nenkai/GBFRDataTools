using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmInitPosSetAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmInitPosSetAction);

    [JsonPropertyName("initPos_")]
    public /* cVec4 */ Vector4 InitPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("initRotDegY_")]
    public float InitRotDegY { get; set; } = 0.0f;
}
