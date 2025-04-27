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

using GBFRDataTools.Entities.Parameters.Base;

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Wyrms.Radis;

public class Em1805RailgunAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em1805RailgunAction);

    public Em1805RailgunAction()
    {
    }
}

