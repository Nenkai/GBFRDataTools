using GBFRDataTools.Entities.Parameters.Base;
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

public class Em1303SummonAppearAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1303SummonAppearAction);

    public Em1303SummonAppearAction()
    {
    }
}
