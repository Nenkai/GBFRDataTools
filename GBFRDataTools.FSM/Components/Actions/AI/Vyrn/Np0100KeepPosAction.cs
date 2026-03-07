using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

using GBFRDataTools.Entities.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Vyrn;

public class Np0100KeepPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Np0100KeepPosAction);

    [JsonPropertyName("offset_")]
    public /* cVec4 */ Vector4 Offset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("middleMaxSpeed_")]
    public float MiddleMaxSpeed { get; set; } = 13.0f;

    [JsonPropertyName("farMaxSpeed_")]
    public float FarMaxSpeed { get; set; } = 20.0f;

    [JsonPropertyName("isMove_")]
    public bool IsMove { get; set; } = true;
}
