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

public class Em1500MoveToAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500MoveToAction);

    [JsonPropertyName("groundMoveMotionId_")]
    public string GroundMoveMotionId { get; set; } // Offset 0x30

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 1f; // Offset 0x38

    [JsonPropertyName("moveEndRange_")]
    public float MoveEndRange { get; set; } = 0f; // Offset 0x3C

    [JsonPropertyName("moveEndTime_")]
    public float MoveEndTime { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("isCheckAnimend_")]
    public bool IsCheckAnimend { get; set; } = false; // Offset 0x44

    public Em1500MoveToAction()
    {
    }
}