using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class AreaEffectSoundSoftCall : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AreaEffectSoundSoftCall);

    [JsonPropertyName("softCallType_")]
    public SoftCallType SoftCallType { get; set; } = SoftCallType.Type0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 1;

    [JsonPropertyName("beginPos_")]
    public /* cVec4 */ Vector4 BeginPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("endPos_")]
    public /* cVec4 */ Vector4 EndPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("defineName_")]
    public string DefineName { get; set; } = string.Empty;

    [JsonPropertyName("isCall_")]
    public bool IsCall { get; set; } = false;

    [JsonPropertyName("isFirst_")]
    public bool IsFirst { get; set; } = false;

    [JsonPropertyName("softCallWorkIndex_")]
    public int SoftCallWorkIndex { get; set; } = 0;
}