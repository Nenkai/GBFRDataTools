using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.SoundMix;

public class SoundMixBalanceQuestIDCondition : ConditionComponent
{
    [JsonPropertyName("isCheckPhase_")]
    public bool IsCheckPhase { get; set; }

    [JsonPropertyName("questIDTop_")]
    public uint QuestIDTop { get; set; }

    [JsonPropertyName("questList_")]
    public BindingList<QuestInfo> QuestList { get; set; }

    [JsonPropertyName("isCheckSection_")]
    public bool IsCheckSection { get; set; }

    public class QuestInfo // SoundMixBalanceQuestIDCondition::QuestInfo
    {
        [JsonPropertyName("questID_")]
        public int QuestID { get; set; }

        [JsonPropertyName("sectionIDList_")]
        public BindingList<uint> SectionIDList { get; set; }
    }
}
