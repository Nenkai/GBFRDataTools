using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800TurnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800TurnAction);

    [JsonPropertyName("canCancel_")]
    public bool CanCancel { get; set; } = false; // Offset 0x30

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = -1f; // Offset 0x34

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = -1f; // Offset 0x38

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; // Offset 0x3C

    public Em1800TurnAction()
    {
    }
}
