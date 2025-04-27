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

public class Em1100AvoidanceAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1100AvoidanceAction);

    public Em1100AvoidanceAction()
    {
    }
}
