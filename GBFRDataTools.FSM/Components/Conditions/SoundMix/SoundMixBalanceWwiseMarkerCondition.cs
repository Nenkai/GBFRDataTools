using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceWwiseMarkerCondition : ConditionComponent
{
    [JsonPropertyName("cueList_")]
    public BindingList<EventCueInfo> CueList { get; set; } = [];

    public class EventCueInfo // SoundMixBalanceWwiseMarkerCondition::EventCueInfo
    {
        [JsonPropertyName("isRestrictEventID_")]
        public bool IsRestrictEventID { get; set; } = false;

        [JsonPropertyName("eventID_")]
        public uint EventID { get; set; } = 0;

        [JsonPropertyName("cueName_")]
        public string CueName { get; set; } = string.Empty;
    }
}

