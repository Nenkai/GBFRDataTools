using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetPlayerInputLimit : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetPlayerInputLimit);

    [JsonPropertyName("actionId_")]
    public int ActionId { get; set; } = 0;

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = false;

    [JsonPropertyName("charaIndex_")]
    public int CharaIndex { get; set; } = 0;

    public override string GetCaption()
    {
        return $"Action: {ActionId} - Enabled: {Enable}";
    }
}
