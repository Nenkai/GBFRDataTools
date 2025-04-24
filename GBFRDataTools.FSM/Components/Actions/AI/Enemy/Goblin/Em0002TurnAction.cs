using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;

public class Em0002TurnAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0002TurnAction);

    public Em0002TurnAction()
    {
    }
}
