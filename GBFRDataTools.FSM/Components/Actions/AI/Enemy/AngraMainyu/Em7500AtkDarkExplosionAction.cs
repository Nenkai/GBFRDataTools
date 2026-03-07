using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AtkDarkExplosionAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkDarkExplosionAction);

    [JsonPropertyName("isTeleport_")]
    public bool IsTeleport { get; set; } = false; // Offset 0x70

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; } = false; // Offset 0x71

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 0.5f; // Offset 0x74

    [JsonPropertyName("startTeleportTime_")]
    public float StartTeleportTime { get; set; } = 2f; // Offset 0x78

    public Em7500AtkDarkExplosionAction()
    {
    }
}

