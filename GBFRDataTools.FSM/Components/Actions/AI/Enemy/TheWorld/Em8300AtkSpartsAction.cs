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
public class Em8300AtkSpartsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8300AtkSpartsAction);

    [JsonPropertyName("warpTime_")]
    public float WarpTime { get; set; } = 0.2f;

    [JsonPropertyName("chargeWaitTime_")]
    public float ChargeWaitTime { get; set; } = 8f;

    [JsonPropertyName("trialTime_")]
    public float TrialTime { get; set; } = 60f;

    [JsonPropertyName("justiceSwordLeftPos_")]
    public BindingList<Vector4> JusticeSwordLeftPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 4)]; // std::array<Hw::cVec4,4>

    [JsonPropertyName("justiceSwordRightPos_")]
    public BindingList<Vector4> JusticeSwordRightPos { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 4)]; // std::array<Hw::cVec4,4>

    [JsonPropertyName("justiceSwordLeftCenterPos_")]
    public Vector4 JusticeSwordLeftCenterPos { get; set; } = new Vector4(10f, 2f, 0f, 1f);

    [JsonPropertyName("justiceSwordRightCenterPos_")]
    public Vector4 JusticeSwordRightCenterPos { get; set; } = new Vector4(-10f, 2f, 0f, 1f);

    [JsonPropertyName("justiceMaxRate_")]
    public float JusticeMaxRate { get; set; } = 0.25f;

    [JsonPropertyName("deathInterval_")]
    public float DeathInterval { get; set; } = 15f;

    [JsonPropertyName("deathFirstInterval_")]
    public float DeathFirstInterval { get; set; } = 3f;

    [JsonPropertyName("playerSetPositions_")]
    public BindingList<Vector4> PlayerSetPositions { get; set; } = [.. Enumerable.Repeat(Vector4.Zero, 4)]; // std::array<Hw::cVec4,4>

    [JsonPropertyName("penaltyHealRate_")]
    public BindingList<float> PenaltyHealRate { get; set; } = [.. Enumerable.Repeat(0.0f, 6)]; // std::array<float,6>

    [JsonPropertyName("chargeOffsetPos_")]
    public Vector4 ChargeOffsetPos { get; set; } = new Vector4(0f, 6.5f, -10f, 1f);

    [JsonPropertyName("visibleLength_")]
    public float VisibleLength { get; set; } = 15f;
}