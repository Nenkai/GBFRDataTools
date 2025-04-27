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
    public int RockNum { get; set; } = 4; // Offset 0x7D4

    [JsonPropertyName("rockDist_")]
    public float RockDist { get; set; } = 10f; // Offset 0x7D8

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 5; // Offset 0x7DC

    [JsonPropertyName("jumpSpeed_")]
    public float JumpSpeed { get; set; } = 0.2f; // Offset 0x7E0

    [JsonPropertyName("isRolling_")]
    public bool IsRolling { get; set; } = false; // Offset 0x7E4

    [JsonPropertyName("speedLevel_")]
    public int SpeedLevel { get; set; } = 0; // Offset 0x7E8

    [JsonPropertyName("isFirstAction_")]
    public bool IsFirstAction { get; set; } = false; // Offset 0x7EC

    [JsonPropertyName("isLastAction_")]
    public bool IsLastAction { get; set; } = false; // Offset 0x7ED

    [JsonPropertyName("isODArts_")]
    public bool IsODArts { get; set; } = false; // Offset 0x7EE

    public Em1500OverDriveAttackAction()
    {
    }
}