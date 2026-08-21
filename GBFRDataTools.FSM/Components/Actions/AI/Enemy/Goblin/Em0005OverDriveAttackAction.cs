using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0005OverDriveAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0005OverDriveAttackAction);

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

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 3; 

    [JsonPropertyName("shotInterval_")]
    public float ShotInterval { get; set; } = 1f; 

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 1f; 

    [JsonPropertyName("shotAngle_")]
    public float ShotAngle { get; set; } = 90f; 

    [JsonPropertyName("movementRateMin_")]
    public float MovementRateMin { get; set; } = 1f; 

    [JsonPropertyName("movementRateMax_")]
    public float MovementRateMax { get; set; } = 2f; 

    [JsonPropertyName("jumpMoveTime_")]
    public float JumpMoveTime { get; set; } = 1f; 

    [JsonPropertyName("targetChangeTime_")]
    public float TargetChangeTime { get; set; } = 5f; 

    [JsonPropertyName("spinTime_")]
    public float SpinTime { get; set; } = 20f; 

    [JsonPropertyName("movementRateTime_")]
    public float MovementRateTime { get; set; } = 10f; 

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.5f; 

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 3f; 

    [JsonPropertyName("finishJumpSpeedY_")]
    public float FinishJumpSpeedY { get; set; } = 0.5f; 

    [JsonPropertyName("finishGravityRate_")]
    public float FinishGravityRate { get; set; } = 3f; 

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.025f; 

    [JsonPropertyName("jumpNum_")]
    public int JumpNum { get; set; } = 3; 
}