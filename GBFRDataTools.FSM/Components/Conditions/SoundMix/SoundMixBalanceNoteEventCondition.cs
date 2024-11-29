using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceNoteEventCondition : ConditionComponent
{
    [JsonPropertyName("eventState_")]
    public int EventState { get; set; } = 0;
}
