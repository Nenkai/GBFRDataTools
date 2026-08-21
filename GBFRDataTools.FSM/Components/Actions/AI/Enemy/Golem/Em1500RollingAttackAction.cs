using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Golem;

public class Em1500RollingAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500RollingAttackAction);

    [JsonPropertyName("assaultTime_")]
    public float AssaultTime { get; set; } = 1.5f; 

    [JsonPropertyName("assaultSpeed_")]
    public float AssaultSpeed { get; set; } = 1f; 

    [JsonPropertyName("assaultNum_")]
    public int AssaultNum { get; set; } = 5; 

    [JsonPropertyName("turningTime_")]
    public float TurningTime { get; set; } = 2.5f; 

    [JsonPropertyName("turningDeceleration_")]
    public float TurningDeceleration { get; set; } = 0.3f; 

    [JsonPropertyName("turningMaxRate_")]
    public float TurningMaxRate { get; set; } = 0.07f; 
}