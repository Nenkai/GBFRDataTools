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
    public Vector4 OffsetPos { get; set; } = Vector4.UnitW; 

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = -1f; 

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; 
}
