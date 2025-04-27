using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AtkHomingShotAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkHomingShotAction);

    [JsonPropertyName("isTeleport_")]
    public bool IsTeleport { get; set; } = false; // Offset 0x74

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; } = false; // Offset 0x75

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 0.5f; // Offset 0x78

    [JsonPropertyName("startTeleportTime_")]
    public float StartTeleportTime { get; set; } = 3f; // Offset 0x7C

    [JsonPropertyName("shotLoopTime_")]
    public float ShotLoopTime { get; set; } = 5f; // Offset 0x70

    public Em7500AtkHomingShotAction()
    {
    }
}

