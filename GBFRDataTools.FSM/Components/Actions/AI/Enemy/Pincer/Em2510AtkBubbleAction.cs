using GBFRDataTools.Entities;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Pincer;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em2510AtkBubbleAction : Em2510JumpMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510AtkBubbleAction);

    [JsonPropertyName("shotInterval_")]
    public float ShotInterval { get; set; } = 0.2f;

    [JsonPropertyName("isJump_")]
    public bool IsJump { get; set; } = false;

    [JsonPropertyName("rushDelayTime_")]
    public float RushDelayTime { get; set; } = 1.0f;

    public Em2510AtkBubbleAction()
    {
        JumpAccelTime = 0.4f;
        JumpTotalTime = 1.3f;
    }
}
