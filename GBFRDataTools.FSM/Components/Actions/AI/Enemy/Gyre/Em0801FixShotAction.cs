using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em0801FixShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0801FixShotAction);

    [JsonPropertyName("shotSpeed_")]
    public float ShotSpeed { get; set; } = 25f;

    [JsonPropertyName("shotMoveSec_")]
    public float ShotMoveSec { get; set; } = 10f;
}
