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

public class BeginSkipStageProductionAction : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(BeginSkipStageProductionAction);

    [JsonPropertyName("productionId_")]
    public string ProductionId { get; set; } = string.Empty;

    public override string? GetCaption()
    {
        return $"ProductionId: {ProductionId}";
    }
}
