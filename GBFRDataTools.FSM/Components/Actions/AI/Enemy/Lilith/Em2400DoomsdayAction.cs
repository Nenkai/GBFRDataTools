using GBFRDataTools.FSM.Components.Actions.Battle;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Lilith;

public class Em2400DoomsdayAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em2400DoomsdayAction);

    public Em2400DoomsdayAction()
    {
    }
}
