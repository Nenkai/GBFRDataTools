using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0004RushAttackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0004RushAttackAction);

    [JsonPropertyName("startPhase_")]
    public int StartPhase { get; set; } = 0; 

    [JsonPropertyName("startHomingAngle_")]
    public float StartHomingAngle { get; set; } = 5f; 

    [JsonPropertyName("loopHomingAngle_")]
    public float LoopHomingAngle { get; set; } = 1f; 

    [JsonPropertyName("loopMotionSeconds_")]
    public float LoopMotionSeconds { get; set; } = 0.7f; 

    [JsonPropertyName("endDistance_")]
    public float EndDistance { get; set; } = 2f; 

    [JsonPropertyName("endAngle_")]
    public float EndAngle { get; set; } = 30f; 

    [JsonPropertyName("endMoveRate_")]
    public float EndMoveRate { get; set; } = 0.5f; 

    [JsonPropertyName("skipEnd_")]
    public bool SkipEnd { get; set; } = false; 
}
