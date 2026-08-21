using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

public class Em7000EnergyBallAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7000EnergyBallAction);

    [JsonPropertyName("sideIndex_")]
    public int SideIndex { get; set; } = 0; 

    [JsonPropertyName("delaySecond_")]
    public float DelaySecond { get; set; } = 0.05f; 

    [JsonPropertyName("lockOnListParam_")]
    public Em7000LockOnListParam LockOnListParam { get; set; } = new(); 
}
