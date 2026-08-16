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
public class Em2510ReturnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510ReturnAction);

    [JsonPropertyName("startWaitTime_")]
    public float StartWaitTime { get; set; } = 1f;
}
