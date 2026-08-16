using GBFRDataTools.Entities;
using GBFRDataTools.Entities.Parameters.Base;

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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.OmnisZegalith;

[GameSupport(GameVersion.EndlessRagnarok)]
public class Em8400AtkFallPlasmaAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em8400AtkFallPlasmaAction);

    [JsonPropertyName("actionEndIntervalFrame_")]
    public int ActionEndIntervalFrame { get; set; } = 75;

    [JsonPropertyName("fsmName_")]
    public string FsmName { get; set; } = "shot_fall_plasma";

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 4;

    [JsonPropertyName("shotRapidFrame_")]
    public int ShotRapidFrame { get; set; } = 20;

    [JsonPropertyName("targetSearchNum_")]
    public int TargetSearchNum { get; set; } = 4;

    [JsonPropertyName("randomOffsetRandMin_")]
    public int RandomOffsetRandMin { get; set; } = 2;

    [JsonPropertyName("randomOffsetRandMax_")]
    public int RandomOffsetRandMax { get; set; } = 4;

    [JsonPropertyName("randomOffsetDistanceValue_")]
    public float RandomOffsetDistanceValue { get; set; } = 2.5f;

    [JsonPropertyName("isPlayMotion_")]
    public bool IsPlayMotion { get; set; } = true;
}
