using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.Quest;

public class UpdateGroupSceneObject : QuestActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(UpdateGroupSceneObject);

    [JsonPropertyName("upperUuid_")]
    public ulong UpperUuid { get; set; } = 0;

    [JsonPropertyName("lowerUuid_")]
    public ulong LowerUuid { get; set; } = 0;

    [JsonPropertyName("active_")]
    public bool Active { get; set; } = false;
}
