using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.EnemySpecific;

public class AiEm7200PlayerOdArts : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(AiEm7200PlayerOdArts);
}
