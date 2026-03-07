using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500CounterAttackAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500CounterAttackAction);

    [JsonPropertyName("shotSearchNearDist_")]
    public float ShotSearchNearDist { get; set; } = 12f; // Offset 0x3C

    [JsonPropertyName("shotSearchFarDist_")]
    public float ShotSearchFarDist { get; set; } = 30f; // Offset 0x40

    [JsonPropertyName("shotLandingTime_")]
    public float ShotLandingTime { get; set; } = 2f; // Offset 0x44

    [JsonPropertyName("shotLandingAddTIme_")]
    public float ShotLandingAddTIme { get; set; } = 0.2f; // Offset 0x48

    [JsonPropertyName("shotAttackRadius_")]
    public float ShotAttackRadius { get; set; } = 3f; // Offset 0x4C

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.4f; // Offset 0x50

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1.5f; // Offset 0x54

    [JsonPropertyName("rockOffsetDist_")]
    public float RockOffsetDist { get; set; } = 3f; // Offset 0x58

    [JsonPropertyName("rockCollisionMargin_")]
    public float RockCollisionMargin { get; set; } = 0.7f; // Offset 0x5C

    public Em1500CounterAttackAction()
    {
    }
}