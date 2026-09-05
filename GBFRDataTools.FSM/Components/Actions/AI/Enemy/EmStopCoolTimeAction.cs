using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

[GameSupport(GameVersion.EndlessRagnarok)]
public class EmStopCoolTimeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmStopCoolTimeAction);

    [JsonPropertyName("isAllStop_")]
    public bool IsAllStop { get; set; } = false;

    [JsonPropertyName("valueName_")]
    public string? ValueName { get; set; }
}
