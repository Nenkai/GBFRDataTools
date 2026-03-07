using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle;

public class Em2100SwordRecoverAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2100SwordRecoverAction);

    [JsonPropertyName("flyingHeight_")]
    public float FlyingHeight { get; set; } = 1f; // Offset 0x34

    [JsonPropertyName("flyingVerticalSpeed_")]
    public float FlyingVerticalSpeed { get; set; } = 1f; // Offset 0x38

    public Em2100SwordRecoverAction()
    {
    }
}