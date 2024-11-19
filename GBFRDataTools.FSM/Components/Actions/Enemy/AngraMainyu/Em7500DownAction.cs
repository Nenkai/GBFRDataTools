using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;
using GBFRDataTools.FSM.Entities;

namespace GBFRDataTools.FSM.Components.Actions.Enemy.AngraMainyu;

public class Em7500DownAction : ActionComponent
{
    [JsonPropertyName("isDownCamera_")]
    public bool IsDownCamera { get; set; }

    [JsonPropertyName("isLightPillerStun_")]
    public bool IsLightPillerStun { get; set; }

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; }

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; }
}
