using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800ClawAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800ClawAction);

    [JsonPropertyName("canCancel_")]
    public bool CanCancel { get; set; } = false; // Offset 0x31

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0; // Offset 0x34

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; // Offset 0x38

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; // Offset 0x3C

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; // Offset 0x40

    public Em1800ClawAction()
    {
    }
}
