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
    public float ShotSearchNearDist { get; set; } = 12f; 

    [JsonPropertyName("shotSearchFarDist_")]
    public float ShotSearchFarDist { get; set; } = 30f; 

    [JsonPropertyName("shotLandingTime_")]
    public float ShotLandingTime { get; set; } = 2f; 

    [JsonPropertyName("shotLandingAddTIme_")]
    public float ShotLandingAddTIme { get; set; } = 0.2f; 

    [JsonPropertyName("shotAttackRadius_")]
    public float ShotAttackRadius { get; set; } = 3f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.4f; 

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 1.5f; 

    [JsonPropertyName("rockOffsetDist_")]
    public float RockOffsetDist { get; set; } = 3f; 

    [JsonPropertyName("rockCollisionMargin_")]
    public float RockCollisionMargin { get; set; } = 0.7f; 
}