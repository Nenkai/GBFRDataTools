using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.PlayerAI.CharaSpecific;

public class Pl2100GuardWaitAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Pl2100GuardWaitAction);
}
