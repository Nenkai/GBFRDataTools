using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500AtkOverDriveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500AtkOverDriveAction);

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; } = false; // Offset 0x80

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 0.5f; // Offset 0x7C

    public Em7500AtkOverDriveAction()
    {
    }
}

