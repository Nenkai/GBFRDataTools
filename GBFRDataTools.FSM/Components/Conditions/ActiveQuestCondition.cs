using GBFRDataTools.FSM.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions;

public class ActiveQuestCondition : ConditionComponent
{
    [JsonPropertyName("isCheckChapter_")]
    public bool IsCheckChapter { get; set; } = false;

    [JsonPropertyName("questIdTop_")]
    public uint QuestIdTop { get; set; } = 0;

    [JsonPropertyName("questList_")]
    public BindingList<ActiveQuestCondition_QuestInfo> QuestList { get; set; } = [];

    [JsonPropertyName("isCheckSection_")]
    public bool IsCheckSection { get; set; } = false;

    public class ActiveQuestCondition_QuestInfo // BT::ActiveQuestCondition::QuestInfo
    {
        [JsonPropertyName("questID_")]
        public uint QuestID { get; set; } = 0;

        [JsonPropertyName("sectionIDList_")]
        public BindingList<uint> SectionIDList { get; set; } = [];
    }
}