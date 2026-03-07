using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Quakadiles;

public class Em0501FrozenTargetAction : Em0500BaseAction
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0501FrozenTargetAction);

    public Em0501FrozenTargetAction()
    {
    }
}