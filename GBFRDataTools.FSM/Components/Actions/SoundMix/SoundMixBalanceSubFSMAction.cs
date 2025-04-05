using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceSubFSMAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalanceSubFSMAction);

    [JsonPropertyName("subFSMInfix_")]
    public string SubFSMInfix { get; set; } = string.Empty;

    [JsonPropertyName("isResident_")]
    public bool IsResident { get; set; } = false;
}
