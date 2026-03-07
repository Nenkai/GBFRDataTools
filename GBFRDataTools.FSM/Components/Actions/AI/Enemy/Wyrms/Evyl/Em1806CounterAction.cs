using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Evyl;

public class Em1806CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1806CounterAction);

    [JsonPropertyName("createOffset_")]
    public Vector4 CreateOffset { get; set; } = new Vector4(0f, 0f, -3.5f, 1f); // Offset 0x70

    [JsonPropertyName("omenRadius_")]
    public float OmenRadius { get; set; } = 13f; // Offset 0x80

    public Em1806CounterAction()
    {
    }
}
