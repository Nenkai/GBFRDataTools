using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;
using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803TailAttackAction : Em1800TailAttackAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803TailAttackAction);

    [JsonPropertyName("isOneRotation_")]
    public bool IsOneRotation { get; set; } = false; 

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; 

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; 
}

