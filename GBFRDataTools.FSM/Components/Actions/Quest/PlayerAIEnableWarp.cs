using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class PlayerAIEnableWarp : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(PlayerAIEnableWarp);

    [JsonPropertyName("forceEnable_")]
    public bool ForceEnable { get; set; } = false;

    public override string? GetCaption()
    {
        return $"ForceEnable: {ForceEnable}";
    }
}
