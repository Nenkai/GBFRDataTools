using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

public class IsArchiveWatched : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(IsArchiveWatched);

    [JsonPropertyName("archiveName_")]
    public string ArchiveName { get; set; } = string.Empty;
}
