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
public class Em8401DarkShotCreateShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8401DarkShotCreateShotAction);

    [JsonPropertyName("offsetRotY_")]
    public float OffsetRotY { get; set; } = 0.2617994f;

    [JsonPropertyName("isInfinity_")]
    public bool IsInfinity { get; set; } = false;
}
