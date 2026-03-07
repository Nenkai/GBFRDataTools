using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lucilius;

public class We7700ChopUpAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(We7700ChopUpAction);

    public We7700ChopUpAction()
    {
    }
}
