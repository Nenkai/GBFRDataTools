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
public class Em8303NormalAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8303NormalAction);

    [JsonPropertyName("invincibleHeight_")]
    public float InvincibleHeight { get; set; } = 5f;

    [JsonPropertyName("decelHeight_")]
    public float DecelHeight { get; set; } = 4f;

    [JsonPropertyName("upFirstSpeed_")]
    public float UpFirstSpeed { get; set; } = 1f;

    [JsonPropertyName("upAccel_")]
    public float UpAccel { get; set; } = 0.75f;

    [JsonPropertyName("upDecel_")]
    public float UpDecel { get; set; } = -5f;

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.25f;
}
