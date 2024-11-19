using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class EndTalkEvent : QuestConditionComponent
{
    [JsonPropertyName("groupID_")]
    public string GroupID { get; set; }

    [JsonPropertyName("useQuestParameter_")]
    public bool UseQuestParameter { get; set; }

    [JsonPropertyName("questParameterName_")]
    public string QuestParameterName { get; set; }

    [JsonPropertyName("questParameterHash_")]
    public uint QuestParameterHash { get; set; }
}
