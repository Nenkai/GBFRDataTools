using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class ControlTimelineSystem : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(ControlTimelineSystem);

    [JsonPropertyName("enable_")]
    public bool Enable { get; set; } = true;
}
