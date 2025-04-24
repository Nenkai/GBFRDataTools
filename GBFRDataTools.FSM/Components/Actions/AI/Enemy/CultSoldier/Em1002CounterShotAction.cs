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
    public float MoveDirX { get; set; } = 60f; // Offset 0x34

    [JsonPropertyName("lowTargetMotionDirX_")]
    public float LowTargetMotionDirX { get; set; } = -40f; // Offset 0x38

    [JsonPropertyName("middleTargetMotionDirX_")]
    public float MiddleTargetMotionDirX { get; set; } = 0f; // Offset 0x3C

    [JsonPropertyName("highTargetMotionDirX_")]
    public float HighTargetMotionDirX { get; set; } = 30f; // Offset 0x40

    [JsonPropertyName("targetVerticalJointNo_")]
    public int TargetVerticalJointNo { get; set; } = 0; // Offset 0x44

    [JsonPropertyName("isNormalShotMode_")]
    public bool IsNormalShotMode { get; set; } = false; // Offset 0x49

    [JsonPropertyName("startMotionTime_")]
    public float StartMotionTime { get; set; } = 0f; // Offset 0x4C

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0f; // Offset 0x68

    public Em1002CounterShotAction()
    {
    }
}