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
    public bool IsCheckChapter { get; set; }

    [JsonPropertyName("questIdTop_")]
    public uint QuestIdTop { get; set; }

    [JsonPropertyName("questList_")]
    public BindingList<ActiveQuestCondition_QuestInfo> QuestList { get; set; }

    [JsonPropertyName("isCheckSection_")]
    public bool IsCheckSection { get; set; }

    public class ActiveQuestCondition_QuestInfo // BT::ActiveQuestCondition::QuestInfo
    {
        [JsonPropertyName("questID_")]
        public uint QuestID { get; set; }

        [JsonPropertyName("sectionIDList_")]
        public BindingList<uint> SectionIDList { get; set; }
    }
}