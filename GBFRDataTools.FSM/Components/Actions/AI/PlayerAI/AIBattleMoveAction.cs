using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI;

[Description("Simulates a movement action (6.0 units forward?)")]
public class AIBattleMoveAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AIBattleMoveAction);

    public AIBattleMoveAction()
    {
    }
}
