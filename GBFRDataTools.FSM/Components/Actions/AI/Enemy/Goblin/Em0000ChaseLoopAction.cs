using GBFRDataTools.FSM.Components.Actions.AI.Enemy.ProtoBahamut;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000ChaseLoopAction : Em0000MoveToAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000ChaseLoopAction);

    public Em0000ChaseLoopAction()
    {
    }
}
