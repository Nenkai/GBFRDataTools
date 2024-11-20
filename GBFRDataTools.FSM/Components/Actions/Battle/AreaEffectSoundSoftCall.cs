using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities.Base;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectSoundSoftCall : ActionComponent
{
    [JsonPropertyName("softCallType_")]
    public int SoftCallType { get; set; }

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; }

    [JsonPropertyName("beginPos_")]
    public cVec4 BeginPos { get; set; }

    [JsonPropertyName("endPos_")]
    public cVec4 EndPos { get; set; }

    [JsonPropertyName("defineName_")]
    public string DefineName { get; set; }

    [JsonPropertyName("isCall_")]
    public bool IsCall { get; set; }

    [JsonPropertyName("isFirst_")]
    public bool IsFirst { get; set; }

    [JsonPropertyName("softCallWorkIndex_")]
    public int SoftCallWorkIndex { get; set; }
}