using GBFRDataTools.FSM.Components.Conditions;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class RequestExcavallionFinish : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(RequestExcavallionFinish);

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } = 0;

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } = 0;
}
