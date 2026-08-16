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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400TrialEndAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400TrialEndAction);

    [JsonPropertyName("actionEndWaitTime_")]
    public float ActionEndWaitTime { get; set; } = 3f;
}
