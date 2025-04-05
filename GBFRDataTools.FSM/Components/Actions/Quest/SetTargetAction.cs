using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetTargetAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetTargetAction);

    [JsonPropertyName("playerIndex_")]
    public int PlayerIndex { get; set; } = 0;

    [JsonPropertyName("objectId_")]
    public ulong ObjectId { get; set; } = 0;

    [JsonPropertyName("rootId_")]
    public ulong RootId { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}";

        return str;
    }
}
