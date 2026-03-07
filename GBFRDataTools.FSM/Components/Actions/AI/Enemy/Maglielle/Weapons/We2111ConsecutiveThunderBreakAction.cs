using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Maglielle.Weapons;

public class We2111ConsecutiveThunderBreakAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We2111ConsecutiveThunderBreakAction);

    public We2111ConsecutiveThunderBreakAction()
    {
    }
}

