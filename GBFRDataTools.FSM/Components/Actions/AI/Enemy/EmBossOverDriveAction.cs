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
    public string MotionId { get; set; } // Offset 0x30

    [JsonPropertyName("interSec_")]
    public float InterSec { get; set; } = 0.2f; // Offset 0x48

    public override string GetCaption()
    {
        return $"Motion: {MotionId} - InterSec: {InterSec}s";
    }

    public EmBossOverDriveAction()
    {
    }
}
