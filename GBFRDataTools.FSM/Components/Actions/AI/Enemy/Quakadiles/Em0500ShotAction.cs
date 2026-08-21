using GBFRDataTools.Entities.Base;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500ShotAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500ShotAction);

    [JsonPropertyName("type_")]
    public int Type { get; set; } = 0; 

    [JsonPropertyName("startPhase_")]
    public int StartPhase { get; set; } = 0; 

    [JsonPropertyName("homingAngle_")]
    public float HomingAngle { get; set; } = 2f; 

    [JsonPropertyName("comboCount_")]
    public int ComboCount { get; set; } = 1; 
}



