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

public class Em1100CounterAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1100CounterAction);

    public Em1100CounterAction()
    {
    }
}
