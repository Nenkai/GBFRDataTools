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

public class Em1500OverDriveAttackAction : Em1500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500OverDriveAttackAction);

    [JsonPropertyName("rockNum_")]
    public int RockNum { get; set; } = 4; 

    [JsonPropertyName("rockDist_")]
    public float RockDist { get; set; } = 10f; 

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 5; 

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0.2f; 

    [JsonPropertyName("isRolling_")]
    public bool IsRolling { get; set; } = false; 

    [JsonPropertyName("speedLevel_")]
    public int SpeedLevel { get; set; } = 0; 

    [JsonPropertyName("isFirstAction_")]
    public bool IsFirstAction { get; set; } = false; 

    [JsonPropertyName("isLastAction_")]
    public bool IsLastAction { get; set; } = false; 

    [JsonPropertyName("isODArts_")]
    public bool IsODArts { get; set; } = false; 
}