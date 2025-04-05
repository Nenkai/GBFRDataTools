using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class PstDropReward : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PstDropReward);

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } = 0;

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } = 0;

    [JsonPropertyName("actionDropIdList_")]
    public BindingList<int> ActionDropIdList { get; set; } = []; // 4 elem

    [JsonPropertyName("ultActionDropIdList_")]
    public BindingList<int> UltActionDropIdList { get; set; } = [];
}
