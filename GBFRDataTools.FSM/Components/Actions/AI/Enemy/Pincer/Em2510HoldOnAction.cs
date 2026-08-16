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
public class Em2510HoldOnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2510HoldOnAction);

    [JsonPropertyName("holdTime_")]
    public float HoldTime { get; set; } = 1.5f;

    [JsonPropertyName("lastAttackHoldTime_")]
    public float LastAttackHoldTime { get; set; } = 8.0f;

    [JsonPropertyName("signDelayTime_")]
    public float SignDelayTime { get; set; } = 1.5f;

    [JsonPropertyName("strongMotionRate_")]
    public float StrongMotionRate { get; set; } = 0.5f;

    [JsonPropertyName("signBaseRadius_")]
    public float SignBaseRadius { get; set; } = 3.3f;

    [JsonPropertyName("leftSignOffsetX_")]
    public BindingList<float> LeftSignOffsetX { get; set; } = [.. Enumerable.Repeat(0.0f, 4).ToList()]; // std::array<float,4>

    [JsonPropertyName("rightSignOffsetX_")]
    public BindingList<float> RightSignOffsetX { get; set; } = [.. Enumerable.Repeat(0.0f, 4).ToList()]; // std::array<float,4>
}
