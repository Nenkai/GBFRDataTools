using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0000DeadAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0000DeadAction);

    public Em0000DeadAction()
    {
    }
}
