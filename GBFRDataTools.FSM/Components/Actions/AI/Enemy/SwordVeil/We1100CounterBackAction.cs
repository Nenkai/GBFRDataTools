using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.Entities;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.SwordVeil;

public class We1100CounterBackAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We1100CounterBackAction);

    public We1100CounterBackAction()
    {
    }
}
