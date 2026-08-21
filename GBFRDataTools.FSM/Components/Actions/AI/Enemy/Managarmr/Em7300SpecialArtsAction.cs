using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300SpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300SpecialArtsAction);

    [JsonPropertyName("setInterval_")]
    public Vector4 SetInterval { get; set; } = new Vector4(4f, 0f, 0f, 1f); 

    [JsonPropertyName("slashInterval_")]
    public Vector4 SlashInterval { get; set; } = new Vector4(0.8f, 0.8f, 0.8f, 1f); 

    [JsonPropertyName("slashAppearTime_")]
    public float SlashAppearTime { get; set; } = 2f; 

    [JsonPropertyName("slashEndIdleTime_")]
    public float SlashEndIdleTime { get; set; } = 1.5f; 

    [JsonPropertyName("changeEndIdleTime_")]
    public float ChangeEndIdleTime { get; set; } = 1f; 

    [JsonPropertyName("endIdleTime_")]
    public float EndIdleTime { get; set; } = 1f; 
}
