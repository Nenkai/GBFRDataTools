using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300FangRequestAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300FangRequestAction);

    [JsonPropertyName("time_")]
    public float Time { get; set; } = 0f; 

    [JsonPropertyName("callEnd_")]
    public bool CallEnd { get; set; } = false; 

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; 
}