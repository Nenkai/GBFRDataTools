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
public class Em2510KnockbackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510KnockbackAction);

    [JsonPropertyName("radius_")]
    public float Radius { get; set; } = 10.0f;

    [JsonPropertyName("power_")]
    public float Power { get; set; } = 1.0f;

    [JsonPropertyName("delay_")]
    public float Delay { get; set; } = 0.0f;
}
