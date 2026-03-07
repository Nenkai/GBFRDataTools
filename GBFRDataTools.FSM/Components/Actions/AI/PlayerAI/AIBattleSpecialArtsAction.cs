using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Simulates a SBA action from the player. 
    Requires full sba gauge.
    """)]
    
public class AIBattleSpecialArtsAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleSpecialArtsAction);

    [JsonPropertyName("waitTime_")]
    public float WaitTime { get; set; } = 0.5f;
}
