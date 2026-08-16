using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith.LogosEcho;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8401DeadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401DeadAction);

    [JsonPropertyName("presageSec_")]
    public float PresageSec { get; set; } = 1.5f;

    [JsonPropertyName("explodeSec_")]
    public float ExplodeSec { get; set; } = 3f;
}
