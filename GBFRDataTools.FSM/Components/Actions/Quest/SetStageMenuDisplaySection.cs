using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class SetStageMenuDisplaySection : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(SetStageMenuDisplaySection);

    [JsonPropertyName("enableFlag_")]
    public bool EnableFlag { get; set; } = false;
}
