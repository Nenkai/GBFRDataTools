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

namespace GBFRDataTools.FSM.Components.Actions.AI.Enemy.Managarmr;

public class Em7300IceDropAction : ActionComponent
{
    [JsonIgnore]
    public override string ComponentName => nameof(Em7300IceDropAction);

    public Em7300IceDropAction()
    {
    }
}

