using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotSetSoundCallPosAction : ActionComponent
{
    [JsonPropertyName("softCallType_")]
    public int SoftCallType { get; set; }

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; }

    [JsonPropertyName("beginPos_")]
    public cVec4 BeginPos { get; set; }

    [JsonPropertyName("endPos_")]
    public cVec4 EndPos { get; set; }
}
