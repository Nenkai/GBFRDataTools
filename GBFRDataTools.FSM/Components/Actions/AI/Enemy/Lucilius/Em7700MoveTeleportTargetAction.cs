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

public class Em7700MoveTeleportTargetAction : Em7700MoveTeleportBaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700MoveTeleportTargetAction);

    [JsonPropertyName("offsetDistance_")]
    public float OffsetDistance { get; set; } = 2f; // Offset 0xB0

    [JsonPropertyName("useVoice_")]
    public bool UseVoice { get; set; } = true; // Offset 0xB9

    [JsonPropertyName("randRotY_")]
    public float RandRotY { get; set; } = 0f; // Offset 0xB4

    [JsonPropertyName("useStartMotion_")]
    public bool UseStartMotion { get; set; } = false; // Offset 0xB8

    public Em7700MoveTeleportTargetAction()
    {
    }
}


