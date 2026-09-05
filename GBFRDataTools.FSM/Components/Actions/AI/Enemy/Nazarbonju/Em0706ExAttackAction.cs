using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;
using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Nazarbonju;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em0706ExAttackAction : Em0706BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0706ExAttackAction);

    [JsonPropertyName("tackleMoveRate_")]
    public float TackleMoveRate { get; set; } = 1f;

    [JsonPropertyName("signTime_")]
    public float SignTime { get; set; } = 5f;

    [JsonPropertyName("playerSignOffset_")]
    public float PlayerSignOffset { get; set; } = 1f;

    [JsonPropertyName("waitPosOffset_")]
    public float WaitPosOffset { get; set; } = 2f;

    [JsonPropertyName("firstTackleWaitTime_")]
    public float FirstTackleWaitTime { get; set; } = 3f;

    [JsonPropertyName("firstTackleWaitSignTime_")]
    public float FirstTackleWaitSignTime { get; set; } = 0.5f;

    [JsonPropertyName("tackleDriftTime_")]
    public float TackleDriftTime { get; set; } = 1f;

    [JsonPropertyName("nextTackleWaitTime_")]
    public float NextTackleWaitTime { get; set; } = 1f;

    [JsonPropertyName("nextTackleWaitSignTime_")]
    public float NextTackleWaitSignTime { get; set; } = 1f;

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 10f;

    [JsonPropertyName("slowTime_")]
    public float SlowTime { get; set; } = 0.5f;

    [JsonPropertyName("slowLength_")]
    public float SlowLength { get; set; } = 15f;

    [JsonPropertyName("tackleEndLength_")]
    public float TackleEndLength { get; set; } = 4f;

    [JsonPropertyName("driftSpeed_")]
    public float DriftSpeed { get; set; } = 1f;

    [JsonPropertyName("driftMinSpeed_")]
    public float DriftMinSpeed { get; set; } = 0.1f;

    [JsonPropertyName("driftCheckLength_")]
    public float DriftCheckLength { get; set; } = 3f;

    [JsonPropertyName("collisionCheckY_")]
    public float CollisionCheckY { get; set; } = -17f; // Offset 0x194

    [JsonPropertyName("smallPillerSpeedRateData_")]
    public BindingList<float> SmallPillerSpeedRateData { get; set; } = []; // std::vector<float>

    [JsonPropertyName("smallPillerMinSpeedRate_")]
    public float SmallPillerMinSpeedRate { get; set; } = 0.2f;

    [JsonPropertyName("createWaveNum_")]
    public int CreateWaveNum { get; set; } = 2;

    [JsonPropertyName("middlePillerCount_")]
    public int MiddlePillerCount { get; set; } = 4;

    [JsonPropertyName("lowPillerCount_")]
    public int LowPillerCount { get; set; } = 7;

    public Em0706ExAttackAction()
    {
        IsSingleAction = false;
        IsComboBefore = false;
        IsComboAfter = false;
        IsActionEndDefaultHeight = false;
    }
}