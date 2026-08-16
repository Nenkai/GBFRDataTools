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
public class Em2510JumpMoveBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510JumpMoveBaseAction);

    [JsonPropertyName("jumpAccelTime_")]
    public float JumpAccelTime { get; set; } = 0.4f;

    [JsonPropertyName("jumpTotalTime_")]
    public float JumpTotalTime { get; set; } = 1.3f;
}
