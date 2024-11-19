using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotCreateSoundCallAction : ActionComponent
{
    [JsonPropertyName("softCallType_")]
    public int SoftCallType { get; set; }

    [JsonPropertyName("posParam1_")]
    public cVec4 PosParam1 { get; set; }

    [JsonPropertyName("posParam2_")]
    public cVec4 PosParam2 { get; set; }
}
