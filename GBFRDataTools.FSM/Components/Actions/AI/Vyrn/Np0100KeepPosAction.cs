using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Lyria;

public class Np0100KeepPosAction : ActionComponent
{
    [JsonPropertyName("offset_")]
    public cVec4 Offset { get; set; }

    [JsonPropertyName("middleMaxSpeed_")]
    public float MiddleMaxSpeed { get; set; }

    [JsonPropertyName("farMaxSpeed_")]
    public float FarMaxSpeed { get; set; }

    [JsonPropertyName("isMove_")]
    public bool IsMove { get; set; }
}
