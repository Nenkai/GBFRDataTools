using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DispChapter : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DispChapter);

    [JsonPropertyName("chapterId_")]
    public string ChapterId { get; set; } = string.Empty;
}
