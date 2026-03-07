using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class Em7700MoveTeleportGroundAction : Em7700MoveTeleportBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700MoveTeleportGroundAction);

    [JsonPropertyName("offsetY_")]
    public float OffsetY { get; set; } = 0.9f; // Offset 0xB0

    [JsonPropertyName("useVoice_")]
    public bool UseVoice { get; set; } = true; // Offset 0xB6

    [JsonPropertyName("isUseRandomPos_")]
    public bool IsUseRandomPos { get; set; } = false; // Offset 0xB4

    [JsonPropertyName("useStartMotion_")]
    public bool UseStartMotion { get; set; } = false; // Offset 0xB5

    public Em7700MoveTeleportGroundAction()
    {
    }
}


