using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Corvell;

public class Em1803CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1803CounterAction);

    public Em1803CounterAction()
    {
    }
}

