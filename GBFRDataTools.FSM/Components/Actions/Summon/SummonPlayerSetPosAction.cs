using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Summon;

[GameSupport(GameVersion.EndlessRagnarok)]
public class SummonPlayerSetPosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SummonPlayerSetPosAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0;

    [JsonPropertyName("isGroundFit_")]
    public bool IsGroundFit { get; set; } = true;

    [JsonPropertyName("isUseBBPos_")]
    public bool IsUseBBPos { get; set; } = false;

    [JsonPropertyName("bbPosKey_")]
    public string BbPosKey { get; set; }
}
