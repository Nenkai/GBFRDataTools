using GBFRDataTools.Entities;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Beelzebub;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Timers;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.TheWorld;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8303MoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8303MoveAction);

    [JsonPropertyName("isExit_")]
    public bool IsExit { get; set; } = false;

    [JsonPropertyName("moveTargetHeight_")]
    public float MoveTargetHeight { get; set; } = 15f;

    [JsonPropertyName("spartsMoveTargetHeight_")]
    public float SpartsMoveTargetHeight { get; set; } = 2.9f;

    [JsonPropertyName("spartsJusticeBaseHeight_")]
    public float SpartsJusticeBaseHeight { get; set; } = 3f;

    [JsonPropertyName("initialSpeed_")]
    public float InitialSpeed { get; set; } = 5f;

    [JsonPropertyName("maxSpeed_")]
    public float MaxSpeed { get; set; } = 30f;

    [JsonPropertyName("accel_")]
    public float Accel { get; set; } = 10f;

    [JsonPropertyName("waveSignTime_")]
    public float WaveSignTime { get; set; } = 2f;
}
