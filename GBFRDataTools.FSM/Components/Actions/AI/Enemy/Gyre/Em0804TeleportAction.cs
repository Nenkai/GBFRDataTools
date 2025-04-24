using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0804TeleportAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0804TeleportAction);

    [JsonPropertyName("teleportEscape_")]
    public bool TeleportEscape { get; set; } = false; // Offset 0x34

    [JsonPropertyName("startAnimSpd_")]
    public float StartAnimSpd { get; set; } = 1f; // Offset 0x38

    [JsonPropertyName("endAnimSpd_")]
    public float EndAnimSpd { get; set; } = 1f; // Offset 0x3C

    public Em0804TeleportAction()
    {
    }
}
