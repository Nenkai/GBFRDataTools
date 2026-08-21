using GBFRDataTools.FSM.Components.Conditions;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700MoveTeleportBaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700MoveTeleportBaseAction);

    [JsonPropertyName("isForcedTeleport_")]
    public bool IsForcedTeleport { get; set; } = false; 

    [JsonPropertyName("isUseStartMotion_")]
    public bool IsUseStartMotion { get; set; } = false; 

    [JsonPropertyName("isUseTargetRot_")]
    public bool IsUseTargetRot { get; set; } = false; 

    [JsonPropertyName("isUseVoice_")]
    public bool IsUseVoice { get; set; } = true; 

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 0.5f; 

    [JsonPropertyName("movePos_")]
    public Vector4 MovePos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("moveRot_")]
    public Vector4 MoveRot { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("isUseEst_")]
    public bool IsUseEst { get; set; } = false; 

    [JsonPropertyName("useStartEst_")]
    public int UseStartEst { get; set; } = 301; 

    [JsonPropertyName("useEndEst_")]
    public int UseEndEst { get; set; } = 300;
}