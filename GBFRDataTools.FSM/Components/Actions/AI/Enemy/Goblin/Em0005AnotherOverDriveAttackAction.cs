using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005AnotherOverDriveAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005AnotherOverDriveAttackAction);

    [JsonPropertyName("shotSearchNearDist_")]
    public float ShotSearchNearDist { get; set; } = 10f; 

    [JsonPropertyName("shotSearchFarDist_")]
    public float ShotSearchFarDist { get; set; } = 40f; 

    [JsonPropertyName("shotLandingTime_")]
    public float ShotLandingTime { get; set; } = 2f; 

    [JsonPropertyName("shotLandingAddTime_")]
    public float ShotLandingAddTime { get; set; } = 0.07f; 

    [JsonPropertyName("shotAttackRadius_")]
    public float ShotAttackRadius { get; set; } = 3f; 

    [JsonPropertyName("rockOffsetDist_")]
    public float RockOffsetDist { get; set; } = 0f; 

    [JsonPropertyName("jumpMoveTime_")]
    public float JumpMoveTime { get; set; } = 1f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.5f; 

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 3f; 

    [JsonPropertyName("maxJumpDist_")]
    public float MaxJumpDist { get; set; } = 15f; 

    [JsonPropertyName("shotNum_")]
    [Editable(false)]
    public BindingList<float> ShotNum { get; set; } = [.. Enumerable.Repeat(0, 3)];

    [JsonPropertyName("shotAngle_")]
    [Editable(false)]
    public BindingList<float> ShotAngle { get; set; } = [.. Enumerable.Repeat(0, 3)]; 

    [JsonPropertyName("shotFan_")]
    [Editable(false)]
    public BindingList<float> ShotFan { get; set; } = [..Enumerable.Repeat(0, 3)]; 

    [JsonPropertyName("rockAttackRate_")]
    public float RockAttackRate { get; set; } = 1.5f; 

    [JsonPropertyName("rockBreakRate_")]
    public float RockBreakRate { get; set; } = 1.5f; 

    [JsonPropertyName("waveAttackRate_")]
    public float WaveAttackRate { get; set; } = 2f; 

    [JsonPropertyName("waveBreakRate_")]
    public float WaveBreakRate { get; set; } = 2f; 

    [JsonPropertyName("waveHeight_")]
    public float WaveHeight { get; set; } = 1.2f; 

    [JsonPropertyName("waveAttackTime_")]
    public float WaveAttackTime { get; set; } = 2.5f; 

    [JsonPropertyName("waveAttackRot_")]
    public float WaveAttackRot { get; set; } = 90f; 

    [JsonPropertyName("isEnableSecondPhase_")]
    public bool IsEnableSecondPhase { get; set; } = false; 

    [JsonPropertyName("isChangeFinishMotion_")]
    public bool IsChangeFinishMotion { get; set; } = false; 
}
