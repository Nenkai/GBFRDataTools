using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Conditions.Event;

[Description("Returns whether a cutscene event is ongoing (note: there's up to 8 events max at once internally)")]
public class OnEventCondition : ConditionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(OnEventCondition);

    [JsonPropertyName("type_")]
    public EventType Type { get; set; } = 0;

    [JsonPropertyName("id_")]
    public int Id { get; set; } = 0;
}