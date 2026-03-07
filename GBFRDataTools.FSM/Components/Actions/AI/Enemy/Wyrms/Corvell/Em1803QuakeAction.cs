using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803QuakeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803QuakeAction);

    [JsonPropertyName("offsetPos_")]
    public Vector4 OffsetPos { get; set; } = new Vector4(0f, 0f, 0f, 1f); // Offset 0x50

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; // Offset 0x60

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = -1f; // Offset 0x64

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; // Offset 0x68

    public Em1803QuakeAction()
    {
    }
}
