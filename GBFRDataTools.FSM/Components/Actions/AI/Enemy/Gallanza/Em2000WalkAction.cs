using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gallanza;

public class Em2000WalkAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2000WalkAction);

    [JsonPropertyName("homingRate_")]
    public float HomingRate { get; set; } = 2f; 

    [JsonPropertyName("loopSec_")]
    public float LoopSec { get; set; } = 0f; 

    [JsonPropertyName("walkDirType_")]
    public int WalkDirType { get; set; } = 0; 

    [JsonPropertyName("isPlayEndMotion_")]
    public bool IsPlayEndMotion { get; set; } = false; 
}
