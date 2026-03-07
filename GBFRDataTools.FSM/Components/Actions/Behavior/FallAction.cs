using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class FallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(FallAction);

    [JsonPropertyName("jumpSpeed_")]
    public /* cVec4 */ Vector4 JumpSpeed { get; set; } = Vector4.UnitW;

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; } = false;

    [JsonPropertyName("isFallEnable_")]
    public bool IsFallEnable { get; set; } = true;

    [JsonPropertyName("isSetJumpSpeed_")]
    public bool IsSetJumpSpeed { get; set; } = false;

    [JsonPropertyName("isSetFlying_")]
    public bool IsSetFlying { get; set; } = false;

    [JsonPropertyName("isFlying_")]
    public bool IsFlying { get; set; } = false;
}
