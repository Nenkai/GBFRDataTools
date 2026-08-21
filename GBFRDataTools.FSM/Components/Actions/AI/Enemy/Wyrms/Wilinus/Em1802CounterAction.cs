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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Wilinus;

public class Em1802CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1802CounterAction);

    [JsonPropertyName("iceGravelNum_")]
    public int IceGravelNum { get; set; } = 36; 

    [JsonPropertyName("angleDivisionNum_")]
    public int AngleDivisionNum { get; set; } = 6; 

    [JsonPropertyName("startMaxDis_")]
    public float StartMaxDis { get; set; } = 11.5f; 

    [JsonPropertyName("startMinDis_")]
    public float StartMinDis { get; set; } = 7f; 

    [JsonPropertyName("maxLength_")]
    public float MaxLength { get; set; } = 20f; 

    [JsonPropertyName("minLength_")]
    public float MinLength { get; set; } = 10f; 

    [JsonPropertyName("toPlayerGravelMaxDis")]
    public float ToPlayerGravelMaxDis { get; set; } = 7f; 

    [JsonPropertyName("toPlayerGravelMinDis")]
    public float ToPlayerGravelMinDis { get; set; } = 5f; 
}
