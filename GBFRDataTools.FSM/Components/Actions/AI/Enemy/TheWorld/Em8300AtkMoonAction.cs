using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8300AtkMoonAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkMoonAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.4f; 

    [JsonPropertyName("attackTime_")]
    public float AttackTime { get; set; } = 5f;

    [JsonPropertyName("laserTime_")]
    public float LaserTime { get; set; } = 1f;

    [JsonPropertyName("magicTime_")]
    public float MagicTime { get; set; } = 2.5f;

    [JsonPropertyName("laserWaitTime_")]
    public float LaserWaitTime { get; set; } = 1.5f;

    [JsonPropertyName("magicDelayTime_")]
    public float MagicDelayTime { get; set; } = 0.5f;

    [JsonPropertyName("createRadius_")]
    public float CreateRadius { get; set; } = 3f;

    [JsonPropertyName("lineMoveSpeedMax_")]
    public float LineMoveSpeedMax { get; set; } = 5f;

    [JsonPropertyName("lineMoveSpeedMin_")]
    public float LineMoveSpeedMin { get; set; } = 0.5f;

    [JsonPropertyName("firstStartPos_")]
    public BindingList<Vector4> FirstStartPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 4)]; // std::array<Hw::cVec4,4>

    [JsonPropertyName("secondStartPos_")]
    public BindingList<Vector4> SecondStartPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 4)]; // std::array<Hw::cVec4,4>

    [JsonPropertyName("windTime_")]
    public float WindTime { get; set; } = 1f;
}