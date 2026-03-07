using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Event;

// There's up to 8 events it seems
[Description("Returns whether a specific cutscene event has ended (note: there's up to 8 events max at once internally)")]
public class EndEventCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EndEventCondition);

    [JsonPropertyName("type_")]
    public EventType Type { get; set; } = 0;

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;
}
