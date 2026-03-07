using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotSetSoundCallPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotSetSoundCallPosAction);

    [JsonPropertyName("softCallType_")]
    public int SoftCallType { get; set; } = 0;

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 1;

    [JsonPropertyName("beginPos_")]
    public /* cVec4 */ Vector4 BeginPos { get; set; } = Vector4.UnitW;

    [JsonPropertyName("endPos_")]
    public /* cVec4 */ Vector4 EndPos { get; set; } = Vector4.UnitW;
}
