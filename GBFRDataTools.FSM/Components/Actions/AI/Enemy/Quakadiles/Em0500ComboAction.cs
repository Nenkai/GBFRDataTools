using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500ComboAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500ComboAction);

    [JsonPropertyName("dobuleSlashCount_")]
    public int DobuleSlashCount { get; set; } = 2; 

    [JsonPropertyName("moveRate_")]
    public float MoveRate { get; set; } = 1.2f; 

    [JsonPropertyName("moveRateEm0501Armor_")]
    public float MoveRateEm0501Armor { get; set; } = 1.5f; 

    [JsonPropertyName("endPhase_")]
    public int EndPhase { get; set; } = 1; 

    [JsonPropertyName("homingAngle1_")]
    public float HomingAngle1 { get; set; } = 2f; 

    [JsonPropertyName("homingAngle2_")]
    public float HomingAngle2 { get; set; } = 2f; 

    [JsonPropertyName("homingAngle3_")]
    public float HomingAngle3 { get; set; } = 5f; 
}


