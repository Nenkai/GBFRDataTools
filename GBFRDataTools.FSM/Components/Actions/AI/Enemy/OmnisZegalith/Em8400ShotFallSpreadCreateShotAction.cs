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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[Obsolete("Not in the executable")]
[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400ShotFallSpreadCreateShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400ShotFallSpreadCreateShotAction);

    [JsonPropertyName("spreadShotNum_")]
    public int SpreadShotNum { get; set; } = 0;
}
