using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AtkChargeLaserAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkChargeLaserAction);

    [JsonPropertyName("isRoundTripVersion_")]
    public bool IsRoundTripVersion { get; set; } = false; // Offset 0x70

    [JsonPropertyName("isLeftVersion_")]
    public bool IsLeftVersion { get; set; } = false; // Offset 0x71

    [JsonPropertyName("isTeleport_")]
    public bool IsTeleport { get; set; } = false; // Offset 0x72

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; } = false; // Offset 0x73

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 0.5f; // Offset 0x74

    public Em7500AtkChargeLaserAction()
    {
    }
}

