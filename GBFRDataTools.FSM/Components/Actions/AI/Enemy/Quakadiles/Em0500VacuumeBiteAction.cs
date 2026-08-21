using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500VacuumeBiteAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500VacuumeBiteAction);

    [JsonPropertyName("biteCount_")]
    public int BiteCount { get; set; } = 1; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 2f; 

    [JsonPropertyName("biteHomingAngle_")]
    public float BiteHomingAngle { get; set; } = 10f; 

    [JsonPropertyName("loopSeconds_")]
    public Vector2 LoopSeconds { get; set; } = new Vector2(2f, 5f); 

    [JsonPropertyName("loopEndDistance_")]
    public float LoopEndDistance { get; set; } = 8f; 

    [JsonPropertyName("vacuumeSpeed_")]
    public Vector4 VacuumeSpeed { get; set; } = new Vector4(0.1f, 0.1f, 0.1f, 0.23f); 

    [JsonPropertyName("vacuumeCenterSpeed_")]
    public float VacuumeCenterSpeed { get; set; } = 0.2f; 

    [JsonPropertyName("vacuumeMinDistance_")]
    public float VacuumeMinDistance { get; set; } = 2f; 

    [JsonPropertyName("vacuumeDistance_")]
    public float VacuumeDistance { get; set; } = 20f; 

    [JsonPropertyName("vacuumeAngle_")]
    public float VacuumeAngle { get; set; } = 120f; 

    [JsonPropertyName("isOnlyVacuume_")]
    public bool IsOnlyVacuume { get; set; } = false; 

    [JsonPropertyName("isTailSlash_")]
    public bool IsTailSlash { get; set; } = false; 

    [JsonPropertyName("moveRateEm0501Armor_")]
    public float MoveRateEm0501Armor { get; set; } = 1.5f; 
}