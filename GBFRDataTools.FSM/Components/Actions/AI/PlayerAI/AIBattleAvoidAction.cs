using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("""
    Simulates a dodge input from the player.
    Direction affected by AIMoveAction.
    """)]
public class AIBattleAvoidAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleAvoidAction);
}
