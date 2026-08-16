using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2510PushCorrectAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510PushCorrectAction);

    [JsonPropertyName("startTime_")]
    public float StartTime { get; set; } = 0.0f;

    [JsonPropertyName("rate_")]
    public float Rate { get; set; } = 1.0f;
}
