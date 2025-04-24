using GBFRDataTools.FSM.Components.Actions.AI.Enemy.Goblin;
using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0500BaseAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0500BaseAction);

    public Em0500BaseAction()
    {
    }
}


