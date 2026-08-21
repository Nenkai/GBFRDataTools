using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class UseItemAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UseItemAction);

    [JsonPropertyName("itemId_")]
    public string? ItemId { get; set; }

    [JsonPropertyName("isConsume_")]
    public bool IsConsume { get; set; } = true;

    public override string? GetCaption()
    {
        return $"Id: {ItemId}, (Consume: {IsConsume})";
    }
}
