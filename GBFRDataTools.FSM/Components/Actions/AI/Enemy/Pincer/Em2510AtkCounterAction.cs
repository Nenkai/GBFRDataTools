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
public class Em2510AtkCounterAction : Em2510JumpMoveBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510AtkCounterAction);

    [JsonPropertyName("isJumpCounter_")]
    public bool IsJumpCounter { get; set; } = false;

    [JsonPropertyName("isTargetPlayer_")]
    public bool IsTargetPlayer { get; set; } = false;

    [JsonPropertyName("signOffset_")]
    public Vector4 SignOffset { get; set; } = Vector4.UnitW;

    [JsonPropertyName("moveDist_")]
    public float MoveDist { get; set; } = 12.0f;

    public Em2510AtkCounterAction()
    {
        JumpAccelTime = 0.4f;
        JumpTotalTime = 1.3f;
    }
}
