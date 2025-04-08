using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.AngraMainyu;

public class Em7500DownAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7500DownAction);

    [JsonPropertyName("isDownCamera_")]
    public bool IsDownCamera { get; set; } = false;

    [JsonPropertyName("isLightPillerStun_")]
    public bool IsLightPillerStun { get; set; } = false;

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; } = false;

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 1.0f;
}
