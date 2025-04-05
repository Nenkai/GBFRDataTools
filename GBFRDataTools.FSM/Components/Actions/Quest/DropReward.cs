using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DropReward : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DropReward);

    [JsonPropertyName("actionDropId_")]
    public int ActionDropId { get; set; } = 0;

    public override string ToString()
    {
        string str = $"{ComponentName}(id: {ActionDropId})";

        return str;
    }
}
