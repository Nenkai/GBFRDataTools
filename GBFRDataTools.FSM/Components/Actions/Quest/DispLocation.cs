using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class DispLocation : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(DispLocation);

    [JsonPropertyName("locationId_")]
    public string LocationId { get; set; } = string.Empty;

    public override string GetCaption()
    {
        return LocationId;
    }
}
