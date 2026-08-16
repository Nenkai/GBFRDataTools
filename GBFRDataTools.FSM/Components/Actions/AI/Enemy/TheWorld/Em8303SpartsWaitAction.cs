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
public class Em8303SpartsWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8303SpartsWaitAction);

    [JsonPropertyName("wormHoleOffsetRotRate_")]
    public float WormHoleOffsetRotRate { get; set; } = 0.2f;

    [JsonPropertyName("exitWormHoleOffsetHeight_")]
    public float ExitWormHoleOffsetHeight { get; set; } = 6f;

    [JsonPropertyName("justice1Pos_")]
    public Vector4 Justice1Pos { get; set; } = new Vector4(2.5f, 16f, -18f, 1f);

    [JsonPropertyName("justice2Pos_")]
    public Vector4 Justice2Pos { get; set; } = new Vector4(-2.5f, 16f, -18f, 1f);

    [JsonPropertyName("deathPos_")]
    public Vector4 DeathPos { get; set; } = new Vector4(8f, 14f, -15f, 1f);

    [JsonPropertyName("judgementPos_")]
    public Vector4 JudgementPos { get; set; } = new Vector4(-8f, 14f, -15f, 1f);

    [JsonPropertyName("upSpeedFirst_")]
    public float UpSpeedFirst { get; set; } = 3f;

    [JsonPropertyName("upAccel_")]
    public float UpAccel { get; set; } = 20f;

    [JsonPropertyName("upSpeedMax_")]
    public float UpSpeedMax { get; set; } = 20f;

    [JsonPropertyName("upHeight_")]
    public float UpHeight { get; set; } = 11f;

    [JsonPropertyName("wormHoleCreateHeight_")]
    public float WormHoleCreateHeight { get; set; } = 3f;

    [JsonPropertyName("justice1StartRotY_")]
    public float Justice1StartRotY { get; set; } = 0f;

    [JsonPropertyName("justice2StartRotY_")]
    public float Justice2StartRotY { get; set; } = 0.9424779f;

    [JsonPropertyName("deathStartRotY_")]
    public float DeathStartRotY { get; set; } = 2.1991148f;

    [JsonPropertyName("judgementStartRotY_")]
    public float JudgementStartRotY { get; set; } = 5.0265484f;

    [JsonPropertyName("startWait_")]
    public float StartWait { get; set; } = 2f;
}
