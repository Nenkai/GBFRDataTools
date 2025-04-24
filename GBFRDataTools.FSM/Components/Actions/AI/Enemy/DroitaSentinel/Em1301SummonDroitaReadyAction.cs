using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.DroitaSentinel;

public class Em1301SummonDroitaReadyAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1301SummonDroitaReadyAction);

    public Em1301SummonDroitaReadyAction()
    {
    }
}
