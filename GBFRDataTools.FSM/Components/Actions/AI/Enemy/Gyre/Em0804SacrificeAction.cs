using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using GBFRDataTools.FSM.Components.Actions.Battle;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Gyre;

public class Em0804SacrificeAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em0804SacrificeAction);

    public Em0804SacrificeAction()
    {
    }
}
