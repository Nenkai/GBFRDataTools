using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy;

public class EmBossOverDriveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(EmBossOverDriveAction);

    [JsonPropertyName("motionId_")]
    public string? MotionId { get; set; } 

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = 0.2f; 

    public override string? GetCaption()
    {
        return $"Motion: {MotionId} (InterSec: {InterSec}s)";
    }
}
