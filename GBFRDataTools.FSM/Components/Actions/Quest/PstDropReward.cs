using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class PstDropReward : QuestActionComponent
{
    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; }

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; }

    [JsonPropertyName("actionDropIdList_")]
    public BindingList<int> ActionDropIdList { get; set; } // 4 elem

    [JsonPropertyName("ultActionDropIdList_")]
    public BindingList<int> UltActionDropIdList { get; set; }
}
