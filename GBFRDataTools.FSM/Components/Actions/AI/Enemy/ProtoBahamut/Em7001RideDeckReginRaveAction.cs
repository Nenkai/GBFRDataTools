using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001RideDeckReginRaveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001RideDeckReginRaveAction);

    [JsonPropertyName("phase_")]
    public int Phase { get; set; } = 0; 

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; 

    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; } = true; 

    [JsonPropertyName("pattern_")]
    public int Pattern { get; set; } = 0; 

    [JsonPropertyName("isODAbility_")]
    public bool IsODAbility { get; set; } = false; 
}

