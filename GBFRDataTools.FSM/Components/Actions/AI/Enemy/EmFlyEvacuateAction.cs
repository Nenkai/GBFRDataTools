using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmFlyEvacuateAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmFlyEvacuateAction);

    [JsonPropertyName("motionIdWait_")]
    public string? MotionIdWait { get; set; } 

    [JsonPropertyName("motionIdFlyWait_")]
    public string? MotionIdFlyWait { get; set; } 

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

    [JsonPropertyName("motionIdTakeOff_")]
    public string? MotionIdTakeOff { get; set; } 

    [JsonPropertyName("motionIdLanding_")]
    public string? MotionIdLanding { get; set; } 

    [JsonPropertyName("motionIdDiscover_")]
    public string? MotionIdDiscover { get; set; } 

    [JsonPropertyName("waitLen_")]
    public float WaitLen { get; set; } = 1f; 

    [JsonPropertyName("backLen_")]
    public float BackLen { get; set; } = 10f; 

    [JsonPropertyName("flySpeed_")]
    public float FlySpeed { get; set; } = 0f; 

    [JsonPropertyName("flyUpSpeed_")]
    public float FlyUpSpeed { get; set; } = 2f; 

    [JsonPropertyName("moveTurnRate_")]
    public float MoveTurnRate { get; set; } = 0.1f; 

    [JsonPropertyName("takeOffSeqFlag_")]
    public int TakeOffSeqFlag { get; set; } = 13; 

    [JsonPropertyName("landingSeqFlag_")]
    public int LandingSeqFlag { get; set; } = 12; 

    [JsonPropertyName("isReachActionEnd_")]
    public bool IsReachActionEnd { get; set; } = false; 

    [JsonPropertyName("isAppearAgainReachOnly_")]
    public bool IsAppearAgainReachOnly { get; set; } = false; 
}
