using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.AncientDragon;

public class Em1800ClawAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1800ClawAction);

    [JsonPropertyName("canCancel_")]
    public bool CanCancel { get; set; } = false; 

    [JsonPropertyName("attackType_")]
    public int AttackType { get; set; } = 0; 

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = 0f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = 0f; 

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; 
}
