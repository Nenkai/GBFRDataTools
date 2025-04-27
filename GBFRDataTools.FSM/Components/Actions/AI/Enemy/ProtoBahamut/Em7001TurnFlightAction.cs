using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001TurnFlightAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001TurnFlightAction);

    [JsonPropertyName("movePassIndex_")]
    public int MovePassIndex { get; set; } = 0; // Offset 0x64

    [JsonPropertyName("isForcedDefactMode_")]
    public bool IsForcedDefactMode { get; set; } = false; // Offset 0x74

    public Em7001TurnFlightAction()
    {
    }
}
