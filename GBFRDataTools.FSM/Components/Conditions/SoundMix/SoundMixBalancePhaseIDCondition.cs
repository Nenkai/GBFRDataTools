using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalancePhaseIDCondition : ConditionComponent
{
    [JsonPropertyName("phaseNoList_")]
    public BindingList<int> PhaseNoList { get; set; } = [];
}
