using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.PyetA;

public class Em3100TurnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em3100TurnAction);

    [JsonPropertyName("canCancel_")]
    public bool CanCancel { get; set; } = false; 

    [JsonPropertyName("startSecond_")]
    public float StartSecond { get; set; } = -1f; 

    [JsonPropertyName("interpSecond_")]
    public float InterpSecond { get; set; } = -1f; 

    [JsonPropertyName("cancelSecond_")]
    public float CancelSecond { get; set; } = -1f; 
}

