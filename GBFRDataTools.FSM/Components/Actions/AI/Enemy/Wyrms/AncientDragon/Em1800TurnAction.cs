using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800TackleAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800TackleAction);

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; 

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; 

    [JsonPropertyName("isUseRight_")]
    public bool IsUseRight { get; set; } = false; 

    [JsonPropertyName("isForceUseRight_")]
    public bool IsForceUseRight { get; set; } = false; 

    [JsonPropertyName("isHomingToTarget_")]
    public bool IsHomingToTarget { get; set; } = true; 
}
