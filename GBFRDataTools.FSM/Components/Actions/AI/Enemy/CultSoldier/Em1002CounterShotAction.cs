using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.CultSoldier;

public class Em1002CounterShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1002CounterShotAction);

    [JsonPropertyName("moveDirX_")]
    public float MoveDirX { get; set; } = 60f; 

    [JsonPropertyName("lowTargetMotionDirX_")]
    public float LowTargetMotionDirX { get; set; } = -40f; 

    [JsonPropertyName("middleTargetMotionDirX_")]
    public float MiddleTargetMotionDirX { get; set; } = 0f; 

    [JsonPropertyName("highTargetMotionDirX_")]
    public float HighTargetMotionDirX { get; set; } = 30f; 

    [JsonPropertyName("targetVerticalJointNo_")]
    public int TargetVerticalJointNo { get; set; } = 0; 

    [JsonPropertyName("isNormalShotMode_")]
    public bool IsNormalShotMode { get; set; } = false; 

    [JsonPropertyName("startMotionTime_")]
    public float StartMotionTime { get; set; } = 0f; 

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0f; 
}