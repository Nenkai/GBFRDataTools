using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmEvacuateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmEvacuateAction);

    [JsonPropertyName("motionIdWait_")]
    public string? MotionIdWait { get; set; } 

    [JsonPropertyName("motionIdBackWalkStart_")]
    public string? MotionIdBackWalkStart { get; set; } 

    [JsonPropertyName("motionIdBackWalkLoop_")]
    public string? MotionIdBackWalkLoop { get; set; } 

    [JsonPropertyName("motionIdBackWalkEnd_")]
    public string? MotionIdBackWalkEnd { get; set; } 

    [JsonPropertyName("motionIdFrontWalkStart_")]
    public string? MotionIdFrontWalkStart { get; set; } 

    [JsonPropertyName("motionIdFrontWalkLoop_")]
    public string? MotionIdFrontWalkLoop { get; set; } 

    [JsonPropertyName("motionIdFrontWalkEnd_")]
    public string? MotionIdFrontWalkEnd { get; set; } 

    [JsonPropertyName("motionIdJumpStart_")]
    public string? MotionIdJumpStart { get; set; } 

    [JsonPropertyName("motionIdJumpRaise_")]
    public string? MotionIdJumpRaise { get; set; } 

    [JsonPropertyName("motionIdJumpTop_")]
    public string? MotionIdJumpTop { get; set; } 

    [JsonPropertyName("motionIdJumpFall_")]
    public string? MotionIdJumpFall { get; set; } 

    [JsonPropertyName("motionIdJumpLanding_")]
    public string? MotionIdJumpLanding { get; set; } 

    [JsonPropertyName("motionIdDiscover_")]
    public string? MotionIdDiscover { get; set; } 

    [JsonPropertyName("waitLen_")]
    public float WaitLen { get; set; } = 1f; 

    [JsonPropertyName("backLen_")]
    public float BackLen { get; set; } = 10f; 

    [JsonPropertyName("moveTurnRate_")]
    public float MoveTurnRate { get; set; } = 0.1f; 

    [JsonPropertyName("jumpSeqFlag_")]
    public int JumpSeqFlag { get; set; } = 16; 
}