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
public class Em8300AtkTrialPunishAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkTrialPunishAction);

    [JsonPropertyName("chargeTime_")]
    public float ChargeTime { get; set; } = 12f;

    [JsonPropertyName("infinityChargeTime_")]
    public float InfinityChargeTime { get; set; } = 10f;

    [JsonPropertyName("normalWarpWaitTime_")]
    public float NormalWarpWaitTime { get; set; } = 8.5f;

    [JsonPropertyName("wingWarpWaitTime_")]
    public float WingWarpWaitTime { get; set; } = 10.5f;

    [JsonPropertyName("normalCameraWaitTime_")]
    public float NormalCameraWaitTime { get; set; } = 6f;

    [JsonPropertyName("wingCameraWaitTime_")]
    public float WingCameraWaitTime { get; set; } = 7.5f;

    [JsonPropertyName("waveTime_")]
    public float WaveTime { get; set; } = 0.45f;
}