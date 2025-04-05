using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalancePhaseIDCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SoundMixBalancePhaseIDCondition);

    [JsonPropertyName("phaseNoList_")]
    public BindingList<int> PhaseNoList { get; set; } = [];
}
