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
    public float ShotSearchNearDist { get; set; } = 10f; // Offset 0x98

    [JsonPropertyName("shotSearchFarDist_")]
    public float ShotSearchFarDist { get; set; } = 40f; // Offset 0x9C

    [JsonPropertyName("shotLandingTime_")]
    public float ShotLandingTime { get; set; } = 2f; // Offset 0xA0

    [JsonPropertyName("shotLandingAddTime_")]
    public float ShotLandingAddTime { get; set; } = 0.07f; // Offset 0xA4

    [JsonPropertyName("shotAttackRadius_")]
    public float ShotAttackRadius { get; set; } = 3f; // Offset 0xA8

    [JsonPropertyName("rockOffsetDist_")]
    public float RockOffsetDist { get; set; } = 0f; // Offset 0xAC

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 3; // Offset 0xB0

    [JsonPropertyName("shotInterval_")]
    public float ShotInterval { get; set; } = 1f; // Offset 0xB4

    [JsonPropertyName("rotSpeed_")]
    public float RotSpeed { get; set; } = 1f; // Offset 0xB8

    [JsonPropertyName("shotAngle_")]
    public float ShotAngle { get; set; } = 90f; // Offset 0xBC

    [JsonPropertyName("movementRateMin_")]
    public float MovementRateMin { get; set; } = 1f; // Offset 0xC0

    [JsonPropertyName("movementRateMax_")]
    public float MovementRateMax { get; set; } = 2f; // Offset 0xC4

    [JsonPropertyName("jumpMoveTime_")]
    public float JumpMoveTime { get; set; } = 1f; // Offset 0xC8

    [JsonPropertyName("targetChangeTime_")]
    public float TargetChangeTime { get; set; } = 5f; // Offset 0xCC

    [JsonPropertyName("spinTime_")]
    public float SpinTime { get; set; } = 20f; // Offset 0xD0

    [JsonPropertyName("movementRateTime_")]
    public float MovementRateTime { get; set; } = 10f; // Offset 0xD4

    [JsonPropertyName("jumpSpeedY_")]
    public float JumpSpeedY { get; set; } = 0.5f; // Offset 0xD8

    [JsonPropertyName("gravityRate_")]
    public float GravityRate { get; set; } = 3f; // Offset 0xDC

    [JsonPropertyName("finishJumpSpeedY_")]
    public float FinishJumpSpeedY { get; set; } = 0.5f; // Offset 0xE0

    [JsonPropertyName("finishGravityRate_")]
    public float FinishGravityRate { get; set; } = 3f; // Offset 0xE4

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 0.025f; // Offset 0xE8

    [JsonPropertyName("jumpNum_")]
    public int JumpNum { get; set; } = 3; // Offset 0xEC

    public Em0005OverDriveAttackAction()
    {
    }
}