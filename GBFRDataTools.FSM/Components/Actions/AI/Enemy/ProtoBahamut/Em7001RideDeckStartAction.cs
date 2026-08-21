using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7001RideDeckStartAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7001RideDeckStartAction);

    [JsonPropertyName("side_")]
    public int Side { get; set; } = 0; 

    [JsonPropertyName("isSetPos_")]
    public bool IsSetPos { get; set; } = true; 

    [JsonPropertyName("motionIdName_")]
    public string? MotionIdName { get; set; } 
}

