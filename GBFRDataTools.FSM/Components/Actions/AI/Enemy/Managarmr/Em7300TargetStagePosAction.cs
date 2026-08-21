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

public class Em7300TargetStagePosAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300TargetStagePosAction);

    [JsonPropertyName("setTiming_")]
    public int SetTiming { get; set; } = 0; 

    [JsonPropertyName("stagePosType_")]
    public int StagePosType { get; set; } = 0; 

    [JsonPropertyName("clear_")]
    public bool Clear { get; set; } = false; 
}
