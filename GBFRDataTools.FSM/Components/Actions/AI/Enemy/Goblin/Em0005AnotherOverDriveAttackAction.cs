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
    public float ShotSearchNearDist { get; set; } = 10f; // Offset 0xF0

    [JsonPropertyName("shotSearchFarDist_")]
    public float ShotSearchFarDist { get; set; } = 40f; // Offset 0xF4

    [JsonPropertyName("shotLandingTime_")]
    public float ShotLandingTime { get; set; } = 2f; // Offset 0xF8

    [JsonPropertyName("shotLandingAddTime_")]
    public float ShotLandingAddTime { get; set; } = 0.07f; // Offset 0xFC

    [JsonPropertyName("shotAttackRadius_")]
    public float ShotAttackRadius { get; set; } = 3f; // Offset 0x100

    [JsonPropertyName("rockOffsetDist_")]
    public float RockOffsetDist { get; set; } = 0f; // Offset 0x104

    [JsonPropertyName("jumpMoveTime_")]
    public float JumpMoveTime { get; set; } = 1f; // Offset 0x10C

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.5f; // Offset 0x110

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 3f; // Offset 0x114

    [JsonPropertyName("maxJumpDist_")]
    public float MaxJumpDist { get; set; } = 15f; // Offset 0x108

    [JsonPropertyName("shotNum_")]
    [Editable(false)]
    public BindingList<float> ShotNum { get; set; } = [.. Enumerable.Repeat(0, 3)];// Offset 0x118

    [JsonPropertyName("shotAngle_")]
    [Editable(false)]
    public BindingList<float> ShotAngle { get; set; } = [.. Enumerable.Repeat(0, 3)]; // Offset 0x124

    [JsonPropertyName("shotFan_")]
    [Editable(false)]
    public BindingList<float> ShotFan { get; set; } = [..Enumerable.Repeat(0, 3)]; // Offset 0x130

    [JsonPropertyName("rockAttackRate_")]
    public float RockAttackRate { get; set; } = 1.5f; // Offset 0x13C

    [JsonPropertyName("rockBreakRate_")]
    public float RockBreakRate { get; set; } = 1.5f; // Offset 0x140

    [JsonPropertyName("waveAttackRate_")]
    public float WaveAttackRate { get; set; } = 2f; // Offset 0x144

    [JsonPropertyName("waveBreakRate_")]
    public float WaveBreakRate { get; set; } = 2f; // Offset 0x148

    [JsonPropertyName("waveHeight_")]
    public float WaveHeight { get; set; } = 1.2f; // Offset 0x14C

    [JsonPropertyName("waveAttackTime_")]
    public float WaveAttackTime { get; set; } = 2.5f; // Offset 0x150

    [JsonPropertyName("waveAttackRot_")]
    public float WaveAttackRot { get; set; } = 90f; // Offset 0x154

    [JsonPropertyName("isEnableSecondPhase_")]
    public bool IsEnableSecondPhase { get; set; } = false; // Offset 0x15C

    [JsonPropertyName("isChangeFinishMotion_")]
    public bool IsChangeFinishMotion { get; set; } = false; // Offset 0x15D

    public Em0005AnotherOverDriveAttackAction()
    {
    }
}
