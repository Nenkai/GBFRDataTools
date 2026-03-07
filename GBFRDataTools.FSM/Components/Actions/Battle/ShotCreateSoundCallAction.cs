using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.ComponentModel;

using GBFRDataTools.Entities.Base;
using System.Numerics;

namespace GBFRDataTools.FSM.Components.Actions.Battle;

public class ShotCreateSoundCallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ShotCreateSoundCallAction);

    [JsonPropertyName("softCallType_")]
    public SoftCallType SoftCallType { get; set; } = SoftCallType.Type0;

    [JsonPropertyName("posParam1_")]
    public /* cVec4 */ Vector4 PosParam1 { get; set; } = Vector4.UnitW;

    [JsonPropertyName("posParam2_")]
    public /* cVec4 */ Vector4 PosParam2 { get; set; } = Vector4.UnitW;
}
