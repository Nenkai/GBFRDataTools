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
    public bool IsForcedTeleport { get; set; } = false; // Offset 0x70

    [JsonPropertyName("isUseStartMotion_")]
    public bool IsUseStartMotion { get; set; } = false; // Offset 0x71

    [JsonPropertyName("isUseTargetRot_")]
    public bool IsUseTargetRot { get; set; } = false; // Offset 0x72

    [JsonPropertyName("isUseVoice_")]
    public bool IsUseVoice { get; set; } = true; // Offset 0x73

    [JsonPropertyName("teleportWaitTime_")]
    public float TeleportWaitTime { get; set; } = 0.5f; // Offset 0x74

    [JsonPropertyName("movePos_")]
    public Vector4 MovePos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x80

    [JsonPropertyName("moveRot_")]
    public Vector4 MoveRot { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x90

    [JsonPropertyName("isUseEst_")]
    public bool IsUseEst { get; set; } = false; // Offset 0xA0

    [JsonPropertyName("useStartEst_")]
    public int UseStartEst { get; set; } = 301; // Offset 0xA4

    [JsonPropertyName("useEndEst_")]
    public int UseEndEst { get; set; } = 300; // Offset 0xA8

    public Em7700MoveTeleportBaseAction()
    {
    }
}