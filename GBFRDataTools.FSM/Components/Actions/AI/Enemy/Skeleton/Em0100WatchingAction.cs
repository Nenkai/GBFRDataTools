using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Skeleton;

public class Em0100WatchingAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0100WatchingAction);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.2f; // Offset 0x3C

    [JsonPropertyName("playSec_")]
    public float PlaySec { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = -1f; // Offset 0x44

    [JsonPropertyName("targetDistType_")]
    public int TargetDistType { get; set; } = 0; // Offset 0x48

    [JsonPropertyName("motionIdName_")]
    public string MotionIdName { get; set; } // Offset 0x50

    public Em0100WatchingAction()
    {
    }
}
