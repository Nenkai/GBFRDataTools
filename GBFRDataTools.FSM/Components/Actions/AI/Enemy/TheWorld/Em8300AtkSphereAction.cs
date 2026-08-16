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
public class Em8300AtkSphereAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkSphereAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 1f;

    [JsonPropertyName("loopTime_")]
    public float LoopTime { get; set; } = 19f;

    [JsonPropertyName("finishChargeTime_")]
    public float FinishChargeTime { get; set; } = 8f;

    [JsonPropertyName("finishWaitTime_")]
    public float FinishWaitTime { get; set; } = 8f;

    [JsonPropertyName("wormHoleLifeTime_")]
    public float WormHoleLifeTime { get; set; } = 10f;

    [JsonPropertyName("wormHoleTime_")]
    public BindingList<float> WormHoleTime { get; set; } = []; // std::vector<float>

    [JsonPropertyName("wormHoleMinHeight_")]
    public float WormHoleMinHeight { get; set; } = 8f;

    [JsonPropertyName("wormHoleMaxHeight_")]
    public float WormHoleMaxHeight { get; set; } = 11f;

    [JsonPropertyName("wormHoleOneShotNum_")]
    public int WormHoleOneShotNum { get; set; } = 3;

    [JsonPropertyName("laserWaitTime_")]
    public float LaserWaitTime { get; set; } = 3f;

    [JsonPropertyName("magicCircleTime_")]
    public BindingList<float> MagicCircleTime { get; set; } = []; // std::vector<float>

    [JsonPropertyName("shotTime_")]
    public BindingList<float> ShotTime { get; set; } = []; // std::vector<float>
}