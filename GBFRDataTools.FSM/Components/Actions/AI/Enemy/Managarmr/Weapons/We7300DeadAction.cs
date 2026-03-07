using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr.Weapons;

public class We7300DeadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7300DeadAction);

    public We7300DeadAction()
    {
    }
}
