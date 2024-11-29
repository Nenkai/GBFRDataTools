using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.SoundMix;

public class SoundMixBalanceSubFSMAction : ActionComponent
{
    [JsonPropertyName("subFSMInfix_")]
    public string SubFSMInfix { get; set; } = string.Empty;

    [JsonPropertyName("isResident_")]
    public bool IsResident { get; set; } = false;

}
