using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Quest;

[GameSupport(GameVersion.EndlessRagnarok)]
public class CheckScenarioFinish : QuestConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(CheckScenarioFinish);

    [JsonPropertyName("scenarioId_")]
    public string ScenarioId { get; set; }
}
