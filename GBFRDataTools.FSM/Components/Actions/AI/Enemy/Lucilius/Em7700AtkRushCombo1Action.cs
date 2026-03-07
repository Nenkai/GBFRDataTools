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

public class Em7700AtkRushCombo1Action : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7700AtkRushCombo1Action);

    [JsonPropertyName("useTypeB_")]
    public bool UseTypeB { get; set; } = false; // Offset 0x70

    [JsonPropertyName("startTeleportWait_")]
    public float StartTeleportWait { get; set; } = 1.5f; // Offset 0x74

    [JsonPropertyName("moveSpeed_")]
    public float MoveSpeed { get; set; } = 10f; // Offset 0x78

    public Em7700AtkRushCombo1Action()
    {
    }
}


