using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800TackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800TackleAction);

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; // Offset 0x40

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; // Offset 0x44

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; // Offset 0x48

    [JsonPropertyName("isUseRight_")]
    public bool IsUseRight { get; set; } = false; // Offset 0x3C

    [JsonPropertyName("isForceUseRight_")]
    public bool IsForceUseRight { get; set; } = false; // Offset 0x3D

    [JsonPropertyName("isHomingToTarget_")]
    public bool IsHomingToTarget { get; set; } = true; // Offset 0x3E

    public Em1800TackleAction()
    {
    }
}
