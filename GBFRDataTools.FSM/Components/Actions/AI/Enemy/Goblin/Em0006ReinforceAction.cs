using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

[GameSupport(GameVersion.EndlessRagnarok)]
[Obsolete("Not exposed by the executable.")]
public class Em0006ReinforceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0006ReinforceAction);

    [JsonPropertyName("isShield_")]
    public bool IsShield { get; set; }

    [JsonPropertyName("cameraTimer_")]
    public float CameraTimer { get; set; }
}