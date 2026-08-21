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

public class Em1500BackHandBlow : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1500BackHandBlow);

    [JsonPropertyName("turnRate_")]
    public float TurnRate { get; set; } = 0.05f; 

    [JsonPropertyName("shotNum_")]
    public int ShotNum { get; set; } = 4; 

    [JsonPropertyName("shotRotX_")]
    public float ShotRotX { get; set; } = 0.15f; 

    [JsonPropertyName("shotIntervalTime_")]
    public float ShotIntervalTime { get; set; } = 0.016f; 
}
