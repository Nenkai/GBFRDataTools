using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Behavior;

public class FallAction : ActionComponent
{
    [JsonPropertyName("jumpSpeed_")]
    public cVec4 JumpSpeed { get; set; }

    [JsonPropertyName("isSetStart_")]
    public bool IsSetStart { get; set; }

    [JsonPropertyName("isFallEnable_")]
    public bool IsFallEnable { get; set; }

    [JsonPropertyName("isSetJumpSpeed_")]
    public bool IsSetJumpSpeed { get; set; }

    [JsonPropertyName("isSetFlying_")]
    public bool IsSetFlying { get; set; }

    [JsonPropertyName("isFlying_")]
    public bool IsFlying { get; set; }
}
